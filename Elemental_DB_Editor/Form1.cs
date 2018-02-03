using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Octokit;
using System.Threading;

namespace Elemental_DB_Editor
{
    public partial class ER_Form : Form
    {
        public string Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\ElementalRealms";
        public bool isRaw = false;
        public string ERConnectionString, LastEditorVNotification, PackName="ElementalRealms";
        public string[] SList_Mods;
        public List<string> AllMods = new List<string>();
        public List<string> AllVersions = new List<string>();
        int MpY, MpX, Sw, Sh;
        bool Resizing;
        public ER_Form()
        {
            if (Environment.GetEnvironmentVariable("ERealms", EnvironmentVariableTarget.User) != null)
            {
                Path = Environment.GetEnvironmentVariable("ERealms", EnvironmentVariableTarget.User);
            }
            if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);
            InitializeComponent();
        }

        private void ER_Form_Load(object sender, EventArgs e)
        {
            try
            {
                var MC_editor =new GitHubClient(new ProductHeaderValue("Elemental_Editor")).Repository.Release.GetLatest("ElementalRealms", "MC_Editor");
                string LatestVersion = MC_editor.Result.TagName;

                if (File.Exists(Path + "\\LastEditorNotification.log"))
                {
                    LastEditorVNotification = File.ReadAllText(Path + "\\LastEditorNotification.log");
                }
                File.WriteAllText(Path + "\\LastEditorNotification.log", LatestVersion);
                if (LastEditorVNotification != LatestVersion && LastEditorVNotification !=null)
                {
                    if (MessageBox.Show(MC_editor.Result.Body + "\n Open download?",
                        MC_editor.Result.Name,
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                        System.Diagnostics.Process.Start("https://github.com/ElementalRealms/MC_Editor/releases/download/"+LatestVersion+"/Elemental_DB_Editor.exe");
                }
            }
            catch (AggregateException) { }
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
            //Add raw support
            button_ServerMods.Enabled = false;
            button_ClientMods.Enabled = false;
        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            button_Login.Enabled = false;
            string[] login;
            if (File.Exists(Path + "\\ConString.key"))
                login=File.ReadAllLines(Path + "\\ConString.key")[0].Split(',');
            else
                login = (Microsoft.VisualBasic.Interaction.InputBox("DB Name,Username,Password,IP:", "ERealms Connection", "DB_Name,Username,password,IP")).Split(',');
            if (login.Length!=4)
            {
                MessageBox.Show("You must use the syntax :\"DB_Name,Username,Password,IP\"", "ERealms user error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            ERConnectionString = "server=" + login[3] + ";uid=" + login[1] + ";" +
                                    "pwd=" + login[2] + ";";
            PackName = login[0];
            RefreshSV();

            button_StartRaw.Visible = false;
            comboBox_Versions.Enabled = true;
            button_Login.Visible = false;
            button_addmod.Visible = true;
            button_CVersion.Enabled = true;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            button_submit.Text = "Commiting";
            comboBox_Versions.Enabled = false;
            listBox_Mods.Enabled = false;
            listBox_Version.Enabled = false;
            MySqlConnection conn = new MySqlConnection(ERConnectionString);
            string query = "UPDATE `" + PackName + "`.`Version` SET `Mods`='" + string.Join(",", listBox_Version.Items.Cast<String>().ToList()) + "' WHERE `Version_UID`='" + comboBox_Versions.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            
            query = "UPDATE `" + PackName + "`.`Version` SET `Server`='" + string.Join(",", checkedList_ServerMods.CheckedItems.OfType<string>()) + "' WHERE `Version_UID`='" + comboBox_Versions.Text + "'";
            cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            query = "UPDATE `" + PackName + "`.`Version` SET `Client`='" + string.Join(",", checkedList_ClientMods.CheckedItems.OfType<string>()) + "' WHERE `Version_UID`='" + comboBox_Versions.Text + "'";
            cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
            RefreshSV();
            comboBox_Versions.Enabled = true;
            listBox_Mods.Enabled = true;
            listBox_Version.Enabled = true;
            button_submit.Text = "Sucess";
            new Thread(() => {
                Thread.Sleep(1000);
                Invoke(new MethodInvoker(delegate () { button_submit.Text = "Commit Modlist"; }));
            }).Start();
        }
        private void RefreshServerModsList()
        {
            button_submit.Enabled = false;
            MySqlConnection conn = new MySqlConnection(ERConnectionString);
            string query = "SELECT * FROM " + PackName + ".Version WHERE Version_UID='" + comboBox_Versions.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {conn.OpenAsync();}
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show(ex.Message, "ERealms user error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            checkedList_ServerMods.Items.Clear();
            checkedList_ServerMods.Items.AddRange(AllMods.ToArray());
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                SList_Mods = (dataReader["Server"].ToString()).Split(",".ToCharArray());
            }
            if (SList_Mods.Length > 0 && SList_Mods[0] != "")
                foreach (string ToSelectMods in SList_Mods)
                {
                    checkedList_ServerMods.SetItemChecked(checkedList_ServerMods.Items.IndexOf(ToSelectMods), true);
                }

            dataReader.Close();
            button_submit.Enabled = true;
            dataReader.Close();
            conn.CloseAsync();
        }
        private void RefreshClientModsList()
        {
            button_submit.Enabled = false;
            MySqlConnection conn = new MySqlConnection(ERConnectionString);
            string query = "SELECT * FROM " + PackName + ".Version WHERE Version_UID='" + comboBox_Versions.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            { conn.OpenAsync(); }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show(ex.Message, "ERealms user error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            checkedList_ClientMods.Items.Clear();
            checkedList_ClientMods.Items.AddRange(AllMods.ToArray());
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                SList_Mods = (dataReader["Client"].ToString()).Split(",".ToCharArray());
            }
            if (SList_Mods.Length > 0 && SList_Mods[0] != "")
                foreach (string ToSelectMods in SList_Mods)
                {
                    checkedList_ClientMods.SetItemChecked(checkedList_ClientMods.Items.IndexOf(ToSelectMods), true);
                }

            dataReader.Close();
            button_submit.Enabled = true;
            dataReader.Close();
            conn.CloseAsync();
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
                    listBox_Mods.SelectedIndex = listBox_Mods.FindStringExact(selected);
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
                            for (int i2 = 0; i2 < AllMods.Count; i2++)
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
                    listBox_Version.SelectedIndex = listBox_Version.FindStringExact(selected);
                    listBox_Mods.Items.Remove(selected);
                }
            }
        }

        private void comboBox_Versions_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_Versions.Text != null)
                if (isRaw)
                    RefreshLRaw();
                else
                {
                    RefreshLV();
                    RefreshClientModsList();
                    RefreshServerModsList();
                }
        }

        private void button_addmod_Click(object sender, EventArgs e)
        {
                new Form_AddMod().Show();
                button_addmod.Visible = false;
        }

        public bool VisAddButton{
            set{
                button_addmod.Visible = value;
            }
        }
        public bool VisVersionButton{
            set{
                button_CVersion.Enabled = value;
            }
        }
        public void SelectMod(string value, bool toVersion)
        {
            listBox_Version.Items.Add(value);
            listBox_Mods.Items.Add(value);
            checkedList_ClientMods.Items.Add(value);
            checkedList_ServerMods.Items.Add(value);
            checkedList_ServerMods.SelectedIndex = checkedList_ServerMods.FindStringExact(value);
            checkedList_ClientMods.SelectedIndex = checkedList_ClientMods.FindStringExact(value);
            if (toVersion)
                listBox_Version.SelectedIndex = listBox_Version.FindStringExact(value);
            else
                listBox_Mods.SelectedIndex = listBox_Mods.FindStringExact(value);
        }
        private void button_CVersion_Click(object sender, EventArgs e)
        {
                new Form_CVersion().Show();
                button_CVersion.Enabled = false;
        }
        public void RefreshSV()
        {
            MySqlConnection conn = new MySqlConnection(ERConnectionString);
            string query = "SELECT * FROM "+PackName+".Version";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
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



        private bool mouseDown;
        private Point lastLocation;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Mods_Click(object sender, EventArgs e)
        {
            SwitchPannel(button_Mods);
        }

        private void button_ClientMods_Click(object sender, EventArgs e)
        {
            SwitchPannel(button_ClientMods);
        }

        private void button_ServerMods_Click(object sender, EventArgs e)
        {
            SwitchPannel(button_ServerMods);
        }
        private void SwitchPannel(Button ButtON)
        {
            List<Button> Butts = new List<Button> { button_Mods, button_ClientMods, button_ServerMods };
            List<Panel> Pans = new List<Panel> { panel_Mods, panel_ClientMods, panel_ServerMods };
            foreach (Panel ThisPan in Pans) ThisPan.Visible = false;
            Pans[Butts.IndexOf(ButtON)].Visible=true;            
            ButtON.Visible = false;
            Butts.Remove(ButtON);
            int Pos = 15;
            foreach(Button ThisButt in Butts)
            {
                ThisButt.Visible = true;
                ThisButt.Location = new Point(ThisButt.Location.X, Pos);
                Pos += 60;
            }
        }

        private void button_ToTray_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            Hide();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Show();
        }

        private void ER_Form_Resize(object sender, EventArgs e)
        {
            panel2.Size =new Size(this.Width,panel2.Size.Height);
            panel_SideButt.Size = new Size(panel_SideButt.Size.Width, this.Height-panel2.Height);
            panel_SideButt.Location = new Point(this.Width-panel_SideButt.Width , panel2.Size.Height);
            foreach (Panel PAN in new Panel[] { panel_Mods, panel_ServerMods, panel_ClientMods })
            {
                PAN.Size =new Size(this.Width - panel_SideButt.Width, this.Height - panel2.Height);
                PAN.Location = new Point(0,Convert.ToInt32(panel2.Height));
            }
        }

        private void Resize_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Resizing)
            {
                Width = MousePosition.X - MpX + Sw;
                Height = MousePosition.Y - MpY + Sh;
            }
        }

        private void Resize_panel_MouseDown(object sender, MouseEventArgs e)
        {
            Resizing = true;
            MpY = MousePosition.Y;
            MpX = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }
        private void Resize_panel_MouseUp(object sender, MouseEventArgs e)
        {
            Resizing = false;
        }

        public void RefreshLV()
        {
            button_Login.Visible = false;
            button_submit.Visible = true;
            MySqlConnection conn = new MySqlConnection(ERConnectionString);
            string query = "SELECT * FROM " + PackName + ".Version WHERE Version_UID='" + comboBox_Versions.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);


            try
            {
                conn.OpenAsync();
            }
            catch (MySqlException ex)
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

            query = "SELECT * FROM " + PackName + ".Mods";
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
