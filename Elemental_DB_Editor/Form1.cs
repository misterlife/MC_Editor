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
    public partial class ER_Form : Form
    {
        public string ERConnectionString, ERserver= "51.255.41.80";
        public string[] SList_Mods;
        public List<string> AllMods = new List<string>();
        public List<string> AllVersions = new List<string>();
        public ER_Form()
        {
            InitializeComponent();
        }


        private void ER_Form_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            button_Login.Enabled = false;
           string[] login= (Microsoft.VisualBasic.Interaction.InputBox("Username,Password:", "ERealms Connection", "Username,password")).Split(",".ToCharArray());
            if (login.Length!=2)
            {
                MessageBox.Show("You must use the syntax :\"Username,Password\"", "ERealms user error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            ERConnectionString = "server=" + ERserver + ";uid=" + login[0] + ";" +
                                    "pwd=" + login[1] + ";database=ElementalRealms_ModdedLauncher;";

            RefreshSV();

            comboBox_Versions.Enabled = true;
            button_Login.Enabled = true;
            button_addmod.Enabled = true;
            button_CVersion.Enabled = true;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            comboBox_Versions.Enabled = false;
            listBox_Mods.Enabled = false;
            listBox_Version.Enabled = false;
            MySqlConnection conn = new MySqlConnection(ERConnectionString);
            string query = "UPDATE `ElementalRealms_ModdedLauncher`.`Version` SET `Mods`='"+string.Join(",", listBox_Version.Items.Cast<String>().ToList()) + "' WHERE `Version_UID`='" + comboBox_Versions.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            conn.CloseAsync();
            MessageBox.Show("Sucess", "ERealms Feedback",
                                 MessageBoxButtons.OK, MessageBoxIcon.None);
            RefreshSV();
            comboBox_Versions.Enabled = true;
            listBox_Mods.Enabled = true;
            listBox_Version.Enabled = true;
        }

        private void listBox_Version_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_Version.SelectedItem != null)
            {
                string selected = listBox_Version.SelectedItem.ToString();
                listBox_Mods.Items.Add(selected);
                listBox_Version.Items.Remove(selected);
            }
        }

        private void comboBox_Versions_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshLV();
        }

        private void button_addmod_Click(object sender, EventArgs e)
        {
            new Form_AddMod().Show();
            button_addmod.Visible = false;
        }

        private void listBox_Mods_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_Mods.SelectedItem != null)
            {
                string selected = listBox_Mods.SelectedItem.ToString();
                listBox_Version.Items.Add(selected);
                listBox_Mods.Items.Remove(selected);
            }
        }
        public void ABOn(){
            button_addmod.Visible = true;
        }
        public void VCOn()
        {
            button_CVersion.Enabled = true;
        }

        private void button_CVersion_Click(object sender, EventArgs e)
        {
            new Form_CVersion().Show();
            button_CVersion.Enabled = false;
        }
        public string SelectedVersion()
        {
            return comboBox_Versions.Text;
        }
        public void RefreshSV()
        {
            MySqlConnection conn = new MySqlConnection(ERConnectionString);
            string query = "SELECT * FROM ElementalRealms_ModdedLauncher.Version";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show(ex.Message, "ERealms user error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            comboBox_Versions.Items.Clear();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            AllMods.Clear();
            string tmp41=null;
            AllVersions.Clear();
            while (dataReader.Read())
            {
                tmp41 = dataReader["Version_UID"].ToString();
                comboBox_Versions.Items.Add(tmp41);
                AllVersions.Add(tmp41);
            }

            comboBox_Versions.Text = (tmp41);
            dataReader.Close();
            conn.Close();
        }

        public void RefreshLV()
        {
            button_Login.Visible = false;
            button_submit.Visible = true;
            MySqlConnection conn = new MySqlConnection(ERConnectionString);
            string query = "SELECT * FROM ElementalRealms_ModdedLauncher.Version WHERE Version_UID='" + comboBox_Versions.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);


            try
            {
                conn.OpenAsync();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show(ex.Message, "ERealms user error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            listBox_Mods.Items.Clear();
            listBox_Version.Items.Clear();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                SList_Mods = (dataReader["Mods"].ToString()).Split(",".ToCharArray());
            }
            listBox_Version.Items.AddRange(SList_Mods);
            dataReader.Close();

            query = "SELECT * FROM ElementalRealms_ModdedLauncher.Mods";
            cmd = new MySqlCommand(query, conn);
            dataReader = cmd.ExecuteReader();
            AllMods.Clear();
            while (dataReader.Read())
            {
                string mod = dataReader["FileName"].ToString();
                if (!listBox_Version.Items.Contains(mod))
                    listBox_Mods.Items.Add(mod);
                AllMods.Add(mod);
            }

            button_submit.Enabled = true;
            listBox_Version.Enabled = true;
            listBox_Mods.Enabled = true;
            dataReader.Close();
            conn.CloseAsync();
        }
    }
}
