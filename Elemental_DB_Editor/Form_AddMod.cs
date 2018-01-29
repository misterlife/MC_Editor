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
            SwitchUI(false);
            if (Program.erForm.isRaw)
            {
                if (checkBox_DirectMod.Checked)
                {
                    MessageBox.Show("Direct add does not support the RAW format");
                    checkBox_DirectMod.Checked = false;
                    SwitchUI(true);
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
                            WebRequest webReq= WebRequest.Create(FLink);
                            webReq.Timeout = 7000;
                            string ForwardUri = webReq.GetResponse().ResponseUri.ToString();
                            if (ForwardUri.EndsWith(".jar"))
                                FName = System.IO.Path.GetFileName(ForwardUri);
                        }catch {}
                        //Timeout is long and not nececery for any current website with MC mods
                        /*Get name from header
                        if (FName == "")
                            using (WebClient client = new WebClient())
                            {
                                try {
                                    client.OpenRead(FLink);
                                    string HeaderName = new ContentDisposition(client.ResponseHeaders["content-disposition"]).FileName;
                                    if (HeaderName != null)
                                        FName = HeaderName;
                                }
                                catch {
                                    button_Addmod.Text="Could not resolve FileName";
                                    ResetButtonText();
                                }
                            }
                            */
                        if (FName == "")
                        {
                            SwitchUI(true);
                            button_Addmod.Text = "Failed to resolve name";
                            ResetButtonText(3000);
                            return;
                        }
                    }
                }
                if (FLink == "")
                {
                    SwitchUI(true);
                    button_Addmod.Text = "Missing download link";
                    ResetButtonText(3000);
                    return;
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
                        button_Addmod.Text = "Added: " + FName;
                    }
                    catch (MySqlException ex)
                    {
                        if(MessageBox.Show("Copy to clipboard? \n" + ex.ToString(), "ERealms Error",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.Yes)
                            Clipboard.SetText(ex.ToString());
                        SwitchUI(true);
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
                else {
                    button_Addmod.Text = "Mod already exists";
                }
                ResetButtonText();
            }
            SwitchUI(true);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void ResetButtonText(int i=2000)
        {
            new Thread(() => {
                Thread.Sleep(i);
            try{ Invoke(new MethodInvoker(delegate () { button_Addmod.Text = "Submit"; })); } catch { }
            }).Start();
        }

        private void SwitchUI(bool State)
        {
            textBox1.Enabled = State;
            textBox2.Enabled = State;
            button_Addmod.Enabled = State;
            checkBox_DirectMod.Enabled = State;
        }

        private void Form_AddMod_Load(object sender, EventArgs e){
            Top = Cursor.Position.Y;
            Left = Cursor.Position.X;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter)
                textBox2.Select();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e){
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
