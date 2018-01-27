using System;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mime;

namespace Elemental_DB_Editor
{
    public partial class Form_AddMod : Form
    {
        public Form_AddMod()
        {
            InitializeComponent();
        }

        private void Form_AddMod_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.erForm.ABOn();
        }

        private void button_Addmod_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            if (Program.erForm.isRaw)
            {
                if (checkBox_DirectMod.Checked)
                {
                    MessageBox.Show("Direct add does not support the RAW format");
                    checkBox_DirectMod.Checked = false;
                    return;
                }
                Program.erForm.AllMods.Add(textBox1.Text+"@"+textBox2.Text);
                Program.erForm.RefreshLRaw();
            }
            else
            {
                string FName = textBox1.Text, FLink = textBox2.Text;
                if (FName == ""&&FLink!="")
                {
                    if (FLink.EndsWith(".jar"))
                        FName = System.IO.Path.GetFileName(FLink);
                    if (FName == ""){
                        try {
                            string ForwardUri = WebRequest.Create(FLink).GetResponse().ResponseUri.ToString();
                            if (ForwardUri.EndsWith(".jar"))
                                FName = System.IO.Path.GetFileName(ForwardUri);
                        }catch {}
                        //Get name from header
                        if (FName == "")
                            using (WebClient client = new WebClient())
                            {
                                try {
                                    client.OpenRead(FLink);
                                    string HeaderName = new ContentDisposition(client.ResponseHeaders["content-disposition"]).FileName;
                                    if (HeaderName != null)
                                        FName = HeaderName;
                                }
                                catch { MessageBox.Show("Could not resolve FileName"); }
                            }
                    }
                }
                if (!Program.erForm.AllMods.Contains(FName))
                {
                    MySqlConnection conn = new MySqlConnection(Program.erForm.ERConnectionString);
                    string query = "INSERT INTO `" + Program.erForm.PackName + "`.`Mods` (`FileName`, `URL`) VALUES ('" + FName + "', '" + FLink + "');";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Connection.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }catch(MySqlException ex)
                    {
                        MessageBox.Show("Failed to commit mod: \n "+ex.ToString(), "ERealms Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        return;
                    }
                    conn.CloseAsync();
                    if (checkBox_DirectMod.Checked)
                    {
                        Program.erForm.AddToCurrentVersion(FName);
                        Program.erForm.SelectMod_Version(FName);
                    }
                    else
                    {
                        Program.erForm.RefreshLV();
                        Program.erForm.SelectMod_Mods(FName);
                    }
                }
                else
                    MessageBox.Show("The mod you are trying to add exists", "ERealms Feedback",
                                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                button_Addmod.Text = "Added: " + FName;
                new Thread(()=> {
                    Thread.Sleep(2000);
                    Invoke(new MethodInvoker(delegate () { button_Addmod.Text = "Submit"; }));
                }).Start();
            }
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form_AddMod_Load(object sender, EventArgs e)
        {
            Top = Cursor.Position.Y;
            Left = Cursor.Position.X;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox2.Select();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Addmod.PerformClick();
        }

        private void textBox2_DoubleClick(object sender, EventArgs e){
            textBox2.Text = Clipboard.GetText();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e){
            textBox1.Text = Clipboard.GetText();
        }
    }
}
