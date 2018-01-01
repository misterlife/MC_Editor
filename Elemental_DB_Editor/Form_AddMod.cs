using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
                    }
                    else
                    {
                        Program.erForm.RefreshLV();
                    }
                }
                else
                    MessageBox.Show("The mod you are trying to add exists", "ERealms Feedback",
                                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
