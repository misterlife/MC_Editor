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
    public partial class Form_CVersion : Form
    {
        public Form_CVersion()
        {
            InitializeComponent();
        }

        private void Form_CVersion_Load(object sender, EventArgs e)
        {
            if (Program.erForm.isRaw)
            {
                for(int i = 0; i < Program.erForm.AllVersions.Count; i++)
                {
                    string tmp351 = Program.erForm.AllVersions[i].Split('@')[0];
                    comboBox_InheritMod.Items.Add(tmp351);
                    comboBox_versionEdit.Items.Add(tmp351);
                }
            }
            else
            {
                comboBox_versionEdit.Items.AddRange(Program.erForm.AllVersions.ToArray());
                comboBox_InheritMod.Items.AddRange(Program.erForm.AllVersions.ToArray());
            }
        }

        private void Form_CVersion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.erForm.isRaw)
            {

            }
            else
            {
                Program.erForm.RefreshSV();
                Program.erForm.VCOn();
            }
        }

        private void button_Switch_Click(object sender, EventArgs e)
        {
            if (Program.erForm.isRaw)
            {
                if (comboBox_versionEdit.Enabled)
                {
                    comboBox_versionEdit.Enabled = false;
                    textBox_badge.Enabled = true;
                    textBox_biome.Enabled = true;
                    textBox_config.Enabled = true;
                    textBox_forge.Enabled = true;
                    textBox_script.Enabled = true;
                    checkBox_Dev.Enabled = true;
                    checkBox_Visable.Enabled = true;
                    //Import version settings/load defaults
                    //Also add option to inherit mods if it is a new version
                }
                else
                {
                    //Add / sync version
                }
                Program.erForm.RefreshVRaw();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(Program.erForm.ERConnectionString);
                if (comboBox_versionEdit.Enabled == true)
                {
                    comboBox_versionEdit.Enabled = false;
                    textBox_badge.Enabled = true;
                    textBox_biome.Enabled = true;
                    textBox_config.Enabled = true;
                    textBox_forge.Enabled = true;
                    textBox_script.Enabled = true;
                    checkBox_Dev.Enabled = true;
                    checkBox_Visable.Enabled = true;

                    if (Program.erForm.AllVersions.Contains(comboBox_versionEdit.Text))
                    {
                        string query = "SELECT * FROM " + Program.erForm.PackName + ".Version WHERE Version_UID='" + comboBox_versionEdit.Text + "'";
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
                            Environment.Exit(1);
                        }
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            textBox_config.Text = (dataReader["Config"].ToString());
                            textBox_biome.Text = (dataReader["Biome"].ToString());
                            textBox_script.Text = (dataReader["Script"].ToString());
                            textBox_forge.Text = (dataReader["Forge"].ToString());
                            textBox_badge.Text = (dataReader["Badge"].ToString());
                            checkBox_Dev.Checked = Convert.ToBoolean(int.Parse(dataReader["Dev"].ToString()));
                            checkBox_Visable.Checked = Convert.ToBoolean(int.Parse(dataReader["Visable"].ToString()));
                        }
                        dataReader.Close();
                        conn.Close();
                    }
                    else
                    {
                        Height = this.MaximumSize.Height;
                        comboBox_InheritMod.Text = "none";
                    }

                }
                else
                {
                    //upload version
                    if (Program.erForm.AllVersions.Contains(comboBox_versionEdit.Text))
                    {
                        string query = "UPDATE `" + Program.erForm.PackName + "`.`Version` SET `Config`='" + textBox_config.Text + "', `Biome`='" + textBox_biome.Text + "', `Script`='" + textBox_script.Text + "', `Forge`='" + textBox_forge.Text + "', `Visable`='" + Convert.ToInt32(checkBox_Visable.Checked) + "', `Dev`='" + Convert.ToInt32(checkBox_Dev.Checked) + "', `Badge`='" + textBox_badge.Text + "' WHERE `Version_UID`='" + comboBox_versionEdit.Text + "';";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        conn.CloseAsync();
                        MessageBox.Show("Changed Version", "ERealms Feedback",
                                             MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        string IModList = "";
                        if (comboBox_InheritMod.Text != "none")
                        {
                            string queryI = "SELECT * FROM " + Program.erForm.PackName + ".Version WHERE Version_UID='" + comboBox_InheritMod.Text + "'";
                            MySqlCommand cmdI = new MySqlCommand(queryI, conn);
                            try
                            {
                                conn.Open();
                            }
                            catch (MySqlException ex)
                            {
                                Console.Write(ex.Message);
                                MessageBox.Show(ex.Message, "ERealms user error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Environment.Exit(1);
                            }
                            MySqlDataReader dataReader = cmdI.ExecuteReader();
                            while (dataReader.Read())
                            {
                                IModList = (dataReader["Mods"].ToString());
                            }
                            conn.Close();
                            dataReader.Close();
                        }
                        string query = "INSERT INTO `" + Program.erForm.PackName + "`.`Version` VALUES ('" + comboBox_versionEdit.Text + "', '" + textBox_config.Text + "', '" + textBox_biome.Text + "', '" + textBox_script.Text + "', '" + textBox_forge.Text + "', '" + IModList + "', '" + Convert.ToInt32(checkBox_Visable.Checked) + "', '" + Convert.ToInt32(checkBox_Dev.Checked) + "', '" + textBox_badge.Text + "');";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        conn.CloseAsync();
                        MessageBox.Show("Added Version", "ERealms Feedback",
                                             MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    Program.erForm.RefreshSV();
                    Close();
                }
            }
        }
        
    }
}
