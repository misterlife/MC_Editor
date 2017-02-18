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

        private void Form_AddMod_Load(object sender, EventArgs e)
        {

        }

        private void Form_AddMod_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.erForm.ABOn();
        }

        private void button_Addmod_Click(object sender, EventArgs e)
        {
            string FName = textBox1.Text, FLink = textBox2.Text;
            if (!Program.erForm.AllMods.Contains(FName)) { 
            MySqlConnection conn = new MySqlConnection(Program.erForm.ERConnectionString);
            string query = "INSERT INTO `ElementalRealms_ModdedLauncher`.`Mods` (`FileName`, `URL`) VALUES ('" + FName + "', '" + FLink + "');";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            conn.CloseAsync();
            MessageBox.Show("Added Mod", "ERealms Feedback",
                                 MessageBoxButtons.OK, MessageBoxIcon.None);
            Program.erForm.RefreshLV();
        }else
                MessageBox.Show("The mod you are trying to add exists", "ERealms Feedback",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
