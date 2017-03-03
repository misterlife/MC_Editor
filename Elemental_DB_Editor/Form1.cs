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
        public bool isRaw = false;
        public string ERConnectionString;
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
        private void button_StartRaw_Click(object sender, EventArgs e)
        {
            isRaw = true;
            button_StartRaw.Visible = false;
            button_Login.Visible = false;
            button_Export.Visible = true;
            button_Import.Visible = true;
            button_addmod.Visible = true;
            comboBox_Versions.Enabled = true;
            button_CVersion.Enabled = true;
        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            button_Login.Enabled = false;
           string[] login= (Microsoft.VisualBasic.Interaction.InputBox("Username,Password,IP:", "ERealms Connection", "Username,password,IP")).Split(',');
            if (login.Length!=3)
            {
                MessageBox.Show("You must use the syntax :\"Username,Password,IP\"", "ERealms user error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            ERConnectionString = "server=" + login[3] + ";uid=" + login[0] + ";" +
                                    "pwd=" + login[1] + ";";

            RefreshSV();

            button_StartRaw.Visible = false;
            comboBox_Versions.Enabled = true;
            button_Login.Visible = false;
            button_addmod.Visible = true;
            button_CVersion.Enabled = true;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            comboBox_Versions.Enabled = false;
            listBox_Mods.Enabled = false;
            listBox_Version.Enabled = false;
            MySqlConnection conn = new MySqlConnection(ERConnectionString);
            string query = "UPDATE `ElementalRealms`.`Version` SET `Mods`='"+string.Join(",", listBox_Version.Items.Cast<String>().ToList()) + "' WHERE `Version_UID`='" + comboBox_Versions.Text + "'";
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
                if (isRaw)
                {
                    comboBox_Versions.Enabled = false;
                    for (int i = 0; i < AllVersions.Count; i++)
                    {
                        string[] curVer = AllVersions[i].Split('@');
                        if (curVer[0] == comboBox_Versions.Text)
                        {
                            List<string> tmp518 = curVer[8].Split('|').ToList();
                            tmp518.Remove(listBox_Version.SelectedItem.ToString());
                            curVer[8] = string.Join("|", tmp518);
                            AllVersions[i] = string.Join("@", curVer);
                            break;
                        }
                    }
                    RefreshLRaw();
                    comboBox_Versions.Enabled = true;
                }
                    else
                    {
                        string selected = listBox_Version.SelectedItem.ToString();
                        listBox_Mods.Items.Add(selected);
                        listBox_Version.Items.Remove(selected);
                    }
            }
        }
        private void listBox_Mods_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_Mods.SelectedItem != null)
            {
                if (isRaw)
                {
                    comboBox_Versions.Enabled = false;
                    for (int i = 0; i < AllVersions.Count; i++)
                    {
                        string[] curVer = AllVersions[i].Split('@');
                        if (curVer[0] == comboBox_Versions.Text)
                        {
                            List<string> tmp519 = curVer[8].Split('|').ToList();
                            for (int i2=0;i2<AllMods.Count;i2++)
                            {
                                string tmp120 = listBox_Mods.SelectedItem.ToString();
                                if (AllMods[i2] == tmp120)
                                {
                                    tmp519.Add(tmp120.Split('@')[0]);
                                    break;
                                }
                            }
                            curVer[8] = string.Join("|", tmp519);
                            AllVersions[i] = string.Join("@", curVer);
                            break;
                        }
                    }
                    RefreshLRaw();
                    comboBox_Versions.Enabled = true;
                }
                    else
                    {
                        string selected = listBox_Mods.SelectedItem.ToString();
                        listBox_Version.Items.Add(selected);
                        listBox_Mods.Items.Remove(selected);
                    }
            }
        }

        private void comboBox_Versions_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBox_Versions.Text !=null)
            if (isRaw)
            RefreshLRaw();
            else
            RefreshLV();
        }

        private void button_addmod_Click(object sender, EventArgs e)
        {
                new Form_AddMod().Show();
                button_addmod.Visible = false;
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
            string query = "SELECT * FROM ElementalRealms.Version";
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
                Close();
                return;
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

        private void ER_Form_SizeChanged(object sender, EventArgs e)
        {
            Size tmp412 = new Size((this.Width / 2) - 20, this.Height - 82);
            listBox_Mods.Size = tmp412;
            listBox_Version.Location = new Point((this.Width / 2), listBox_Version.Location.Y);
            listBox_Version.Size = tmp412;
        }


        private void button_Import_Click(object sender, EventArgs e)
        {
            string[] Import = (Microsoft.VisualBasic.Interaction.InputBox("[Versions][Mods]:", "ERealms Raw Import", "[Versions][Mods]")).Split('[',']').Where(c => c != null).ToArray();
            if (Import.Length != 5)
            {
                MessageBox.Show("You must use the syntax :\"[Version...][Mod...]\"", "ERealms user error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            AllMods = Import[3].Split(',').ToList();
            AllVersions = Import[1].Split(',').ToList();
            RefreshVRaw();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Raw data.txt", "["+string.Join(",", AllVersions) +"]"+"[" + string.Join(",", AllMods) + "]");
        }

        public void RefreshVRaw()
        {
            for(int i = 0; i < AllVersions.Count; i++)
            {
                comboBox_Versions.Items.Add(AllVersions[i].Split('@')[0]);
            }
        }
        public void RefreshLRaw()
        {
            listBox_Version.Items.Clear();
            listBox_Mods.Items.Clear();
            listBox_Mods.Enabled = false;
            listBox_Version.Enabled = false;
            for (int i=0; i< AllVersions.Count; i++)
            {
                string[] curVer = AllVersions[i].Split('@');
                if (curVer[0] == comboBox_Versions.Text)
                {
                    listBox_Version.Items.AddRange(curVer[8].Split('|'));
                    break;
                }
            }
            for(int i = 0; i < AllMods.Count; i++)
            {
                if (!listBox_Version.Items.Contains(AllMods[i].Split('@')[0]))
                    listBox_Mods.Items.Add(AllMods[i]);
            }
            listBox_Mods.Enabled = true;
            listBox_Version.Enabled = true;
        }

        public void RefreshLV()
        {
            button_Login.Visible = false;
            button_submit.Visible = true;
            MySqlConnection conn = new MySqlConnection(ERConnectionString);
            string query = "SELECT * FROM ElementalRealms.Version WHERE Version_UID='" + comboBox_Versions.Text + "'";
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
                Close();
                return;
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

            query = "SELECT * FROM ElementalRealms.Mods";
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
