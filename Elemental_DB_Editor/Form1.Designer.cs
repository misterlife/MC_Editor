namespace Elemental_DB_Editor
{
    partial class ER_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ER_Form));
            this.button_Login = new System.Windows.Forms.Button();
            this.button_submit = new System.Windows.Forms.Button();
            this.comboBox_Versions = new System.Windows.Forms.ComboBox();
            this.listBox_Version = new System.Windows.Forms.ListBox();
            this.listBox_Mods = new System.Windows.Forms.ListBox();
            this.button_addmod = new System.Windows.Forms.Button();
            this.button_CVersion = new System.Windows.Forms.Button();
            this.button_StartRaw = new System.Windows.Forms.Button();
            this.button_Import = new System.Windows.Forms.Button();
            this.button_Export = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_ToTray = new System.Windows.Forms.Button();
            this.pictureBox_ERlogo = new System.Windows.Forms.PictureBox();
            this.temp_name = new System.Windows.Forms.Label();
            this.panel_Mods = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_mods = new System.Windows.Forms.TableLayoutPanel();
            this.button_Mods = new System.Windows.Forms.Button();
            this.panel_SideButt = new System.Windows.Forms.Panel();
            this.Resize_panel = new System.Windows.Forms.Panel();
            this.button_ServerMods = new System.Windows.Forms.Button();
            this.button_ClientMods = new System.Windows.Forms.Button();
            this.panel_ClientMods = new System.Windows.Forms.Panel();
            this.checkedList_ClientMods = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_ServerMods = new System.Windows.Forms.Panel();
            this.checkedList_ServerMods = new System.Windows.Forms.CheckedListBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ERlogo)).BeginInit();
            this.panel_Mods.SuspendLayout();
            this.tableLayoutPanel_mods.SuspendLayout();
            this.panel_SideButt.SuspendLayout();
            this.panel_ClientMods.SuspendLayout();
            this.panel_ServerMods.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(508, 20);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(148, 35);
            this.button_Login.TabIndex = 1;
            this.button_Login.Text = "MySQL";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_submit
            // 
            this.button_submit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_submit.Enabled = false;
            this.button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.Location = new System.Drawing.Point(413, 23);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(208, 35);
            this.button_submit.TabIndex = 3;
            this.button_submit.Text = "Commit Modlist";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Visible = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // comboBox_Versions
            // 
            this.comboBox_Versions.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_Versions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Versions.Enabled = false;
            this.comboBox_Versions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Versions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Versions.FormattingEnabled = true;
            this.comboBox_Versions.Location = new System.Drawing.Point(732, 29);
            this.comboBox_Versions.Name = "comboBox_Versions";
            this.comboBox_Versions.Size = new System.Drawing.Size(149, 24);
            this.comboBox_Versions.TabIndex = 4;
            this.comboBox_Versions.SelectedValueChanged += new System.EventHandler(this.comboBox_Versions_SelectedValueChanged);
            // 
            // listBox_Version
            // 
            this.listBox_Version.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Version.Enabled = false;
            this.listBox_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listBox_Version.FormattingEnabled = true;
            this.listBox_Version.ItemHeight = 18;
            this.listBox_Version.Location = new System.Drawing.Point(505, 3);
            this.listBox_Version.Name = "listBox_Version";
            this.listBox_Version.Size = new System.Drawing.Size(496, 501);
            this.listBox_Version.Sorted = true;
            this.listBox_Version.TabIndex = 5;
            this.listBox_Version.DoubleClick += new System.EventHandler(this.listBox_Version_DoubleClick);
            // 
            // listBox_Mods
            // 
            this.listBox_Mods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Mods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Mods.Enabled = false;
            this.listBox_Mods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listBox_Mods.FormattingEnabled = true;
            this.listBox_Mods.ItemHeight = 18;
            this.listBox_Mods.Location = new System.Drawing.Point(3, 3);
            this.listBox_Mods.Name = "listBox_Mods";
            this.listBox_Mods.Size = new System.Drawing.Size(496, 501);
            this.listBox_Mods.Sorted = true;
            this.listBox_Mods.TabIndex = 6;
            this.listBox_Mods.DoubleClick += new System.EventHandler(this.listBox_Mods_DoubleClick);
            // 
            // button_addmod
            // 
            this.button_addmod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_addmod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addmod.Location = new System.Drawing.Point(372, 23);
            this.button_addmod.Name = "button_addmod";
            this.button_addmod.Size = new System.Drawing.Size(35, 35);
            this.button_addmod.TabIndex = 7;
            this.button_addmod.Text = "+";
            this.button_addmod.UseVisualStyleBackColor = true;
            this.button_addmod.Visible = false;
            this.button_addmod.Click += new System.EventHandler(this.button_addmod_Click);
            // 
            // button_CVersion
            // 
            this.button_CVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_CVersion.Enabled = false;
            this.button_CVersion.FlatAppearance.BorderSize = 0;
            this.button_CVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CVersion.Location = new System.Drawing.Point(887, 24);
            this.button_CVersion.Name = "button_CVersion";
            this.button_CVersion.Size = new System.Drawing.Size(28, 28);
            this.button_CVersion.TabIndex = 8;
            this.button_CVersion.Text = "[ ]";
            this.button_CVersion.UseVisualStyleBackColor = true;
            this.button_CVersion.Click += new System.EventHandler(this.button_CVersion_Click);
            // 
            // button_StartRaw
            // 
            this.button_StartRaw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_StartRaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_StartRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_StartRaw.Location = new System.Drawing.Point(354, 20);
            this.button_StartRaw.Name = "button_StartRaw";
            this.button_StartRaw.Size = new System.Drawing.Size(148, 35);
            this.button_StartRaw.TabIndex = 9;
            this.button_StartRaw.Text = "Raw";
            this.button_StartRaw.UseVisualStyleBackColor = true;
            this.button_StartRaw.Click += new System.EventHandler(this.button_StartRaw_Click);
            // 
            // button_Import
            // 
            this.button_Import.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Import.Location = new System.Drawing.Point(413, 23);
            this.button_Import.Name = "button_Import";
            this.button_Import.Size = new System.Drawing.Size(112, 35);
            this.button_Import.TabIndex = 10;
            this.button_Import.Text = "Import";
            this.button_Import.UseVisualStyleBackColor = true;
            this.button_Import.Visible = false;
            this.button_Import.Click += new System.EventHandler(this.button_Import_Click);
            // 
            // button_Export
            // 
            this.button_Export.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Export.Location = new System.Drawing.Point(531, 23);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(112, 35);
            this.button_Export.TabIndex = 11;
            this.button_Export.Text = "Export";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Visible = false;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.button_Close);
            this.panel2.Controls.Add(this.button_CVersion);
            this.panel2.Controls.Add(this.comboBox_Versions);
            this.panel2.Controls.Add(this.button_ToTray);
            this.panel2.Controls.Add(this.button_Export);
            this.panel2.Controls.Add(this.button_Import);
            this.panel2.Controls.Add(this.pictureBox_ERlogo);
            this.panel2.Controls.Add(this.temp_name);
            this.panel2.Controls.Add(this.button_submit);
            this.panel2.Controls.Add(this.button_addmod);
            this.panel2.Controls.Add(this.button_StartRaw);
            this.panel2.Controls.Add(this.button_Login);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 80);
            this.panel2.TabIndex = 20;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button_Close
            // 
            this.button_Close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.button_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Close.BackgroundImage")));
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(1040, 15);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(50, 50);
            this.button_Close.TabIndex = 29;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_ToTray
            // 
            this.button_ToTray.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_ToTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.button_ToTray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ToTray.BackgroundImage")));
            this.button_ToTray.FlatAppearance.BorderSize = 0;
            this.button_ToTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ToTray.Location = new System.Drawing.Point(980, 15);
            this.button_ToTray.Name = "button_ToTray";
            this.button_ToTray.Size = new System.Drawing.Size(50, 50);
            this.button_ToTray.TabIndex = 27;
            this.button_ToTray.TabStop = false;
            this.button_ToTray.UseVisualStyleBackColor = false;
            // 
            // pictureBox_ERlogo
            // 
            this.pictureBox_ERlogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox_ERlogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ERlogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ERlogo.Image")));
            this.pictureBox_ERlogo.Location = new System.Drawing.Point(10, 10);
            this.pictureBox_ERlogo.MaximumSize = new System.Drawing.Size(64, 64);
            this.pictureBox_ERlogo.MinimumSize = new System.Drawing.Size(64, 64);
            this.pictureBox_ERlogo.Name = "pictureBox_ERlogo";
            this.pictureBox_ERlogo.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_ERlogo.TabIndex = 26;
            this.pictureBox_ERlogo.TabStop = false;
            // 
            // temp_name
            // 
            this.temp_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.temp_name.AutoSize = true;
            this.temp_name.BackColor = System.Drawing.Color.Transparent;
            this.temp_name.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_name.ForeColor = System.Drawing.Color.SeaShell;
            this.temp_name.Location = new System.Drawing.Point(80, 25);
            this.temp_name.Name = "temp_name";
            this.temp_name.Size = new System.Drawing.Size(179, 25);
            this.temp_name.TabIndex = 15;
            this.temp_name.Text = "Elemental launcher ";
            // 
            // panel_Mods
            // 
            this.panel_Mods.BackColor = System.Drawing.Color.Transparent;
            this.panel_Mods.Controls.Add(this.tableLayoutPanel_mods);
            this.panel_Mods.Location = new System.Drawing.Point(0, 80);
            this.panel_Mods.Name = "panel_Mods";
            this.panel_Mods.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.panel_Mods.Size = new System.Drawing.Size(1014, 522);
            this.panel_Mods.TabIndex = 21;
            this.panel_Mods.Visible = false;
            // 
            // tableLayoutPanel_mods
            // 
            this.tableLayoutPanel_mods.ColumnCount = 2;
            this.tableLayoutPanel_mods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_mods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_mods.Controls.Add(this.listBox_Mods, 0, 0);
            this.tableLayoutPanel_mods.Controls.Add(this.listBox_Version, 1, 0);
            this.tableLayoutPanel_mods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_mods.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel_mods.Name = "tableLayoutPanel_mods";
            this.tableLayoutPanel_mods.RowCount = 1;
            this.tableLayoutPanel_mods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_mods.Size = new System.Drawing.Size(1004, 507);
            this.tableLayoutPanel_mods.TabIndex = 7;
            // 
            // button_Mods
            // 
            this.button_Mods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Mods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Mods.Location = new System.Drawing.Point(19, 15);
            this.button_Mods.Name = "button_Mods";
            this.button_Mods.Size = new System.Drawing.Size(50, 50);
            this.button_Mods.TabIndex = 22;
            this.button_Mods.Text = "Mods";
            this.button_Mods.UseVisualStyleBackColor = true;
            this.button_Mods.Click += new System.EventHandler(this.button_Mods_Click);
            // 
            // panel_SideButt
            // 
            this.panel_SideButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel_SideButt.Controls.Add(this.Resize_panel);
            this.panel_SideButt.Controls.Add(this.button_ServerMods);
            this.panel_SideButt.Controls.Add(this.button_ClientMods);
            this.panel_SideButt.Controls.Add(this.button_Mods);
            this.panel_SideButt.Location = new System.Drawing.Point(1016, 79);
            this.panel_SideButt.Name = "panel_SideButt";
            this.panel_SideButt.Size = new System.Drawing.Size(84, 523);
            this.panel_SideButt.TabIndex = 23;
            // 
            // Resize_panel
            // 
            this.Resize_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Resize_panel.BackColor = System.Drawing.Color.Gray;
            this.Resize_panel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.Resize_panel.Location = new System.Drawing.Point(69, 508);
            this.Resize_panel.Name = "Resize_panel";
            this.Resize_panel.Size = new System.Drawing.Size(15, 15);
            this.Resize_panel.TabIndex = 25;
            this.Resize_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resize_panel_MouseDown);
            this.Resize_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Resize_panel_MouseMove);
            this.Resize_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Resize_panel_MouseUp);
            // 
            // button_ServerMods
            // 
            this.button_ServerMods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_ServerMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ServerMods.Location = new System.Drawing.Point(19, 135);
            this.button_ServerMods.Name = "button_ServerMods";
            this.button_ServerMods.Size = new System.Drawing.Size(50, 50);
            this.button_ServerMods.TabIndex = 24;
            this.button_ServerMods.Text = "Server Mods";
            this.button_ServerMods.UseVisualStyleBackColor = true;
            this.button_ServerMods.Click += new System.EventHandler(this.button_ServerMods_Click);
            // 
            // button_ClientMods
            // 
            this.button_ClientMods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_ClientMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClientMods.Location = new System.Drawing.Point(19, 75);
            this.button_ClientMods.Name = "button_ClientMods";
            this.button_ClientMods.Size = new System.Drawing.Size(50, 50);
            this.button_ClientMods.TabIndex = 23;
            this.button_ClientMods.Text = "Client Mods";
            this.button_ClientMods.UseVisualStyleBackColor = true;
            this.button_ClientMods.Click += new System.EventHandler(this.button_ClientMods_Click);
            // 
            // panel_ClientMods
            // 
            this.panel_ClientMods.BackColor = System.Drawing.Color.Transparent;
            this.panel_ClientMods.Controls.Add(this.checkedList_ClientMods);
            this.panel_ClientMods.Controls.Add(this.label1);
            this.panel_ClientMods.Location = new System.Drawing.Point(0, 80);
            this.panel_ClientMods.Name = "panel_ClientMods";
            this.panel_ClientMods.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.panel_ClientMods.Size = new System.Drawing.Size(1014, 522);
            this.panel_ClientMods.TabIndex = 7;
            this.panel_ClientMods.Visible = false;
            // 
            // checkedList_ClientMods
            // 
            this.checkedList_ClientMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedList_ClientMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedList_ClientMods.FormattingEnabled = true;
            this.checkedList_ClientMods.Location = new System.Drawing.Point(5, 5);
            this.checkedList_ClientMods.Name = "checkedList_ClientMods";
            this.checkedList_ClientMods.Size = new System.Drawing.Size(1004, 507);
            this.checkedList_ClientMods.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client stuff";
            // 
            // panel_ServerMods
            // 
            this.panel_ServerMods.BackColor = System.Drawing.Color.Transparent;
            this.panel_ServerMods.Controls.Add(this.checkedList_ServerMods);
            this.panel_ServerMods.Location = new System.Drawing.Point(0, 80);
            this.panel_ServerMods.Name = "panel_ServerMods";
            this.panel_ServerMods.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.panel_ServerMods.Size = new System.Drawing.Size(1014, 522);
            this.panel_ServerMods.TabIndex = 8;
            this.panel_ServerMods.Visible = false;
            // 
            // checkedList_ServerMods
            // 
            this.checkedList_ServerMods.BackColor = System.Drawing.SystemColors.Window;
            this.checkedList_ServerMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedList_ServerMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedList_ServerMods.FormattingEnabled = true;
            this.checkedList_ServerMods.Location = new System.Drawing.Point(5, 5);
            this.checkedList_ServerMods.Name = "checkedList_ServerMods";
            this.checkedList_ServerMods.Size = new System.Drawing.Size(1004, 507);
            this.checkedList_ServerMods.Sorted = true;
            this.checkedList_ServerMods.TabIndex = 0;
            // 
            // ER_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel_Mods);
            this.Controls.Add(this.panel_SideButt);
            this.Controls.Add(this.panel_ServerMods);
            this.Controls.Add(this.panel_ClientMods);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ER_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERealms Editor";
            this.Load += new System.EventHandler(this.ER_Form_Load);
            this.Resize += new System.EventHandler(this.ER_Form_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ERlogo)).EndInit();
            this.panel_Mods.ResumeLayout(false);
            this.tableLayoutPanel_mods.ResumeLayout(false);
            this.panel_SideButt.ResumeLayout(false);
            this.panel_ClientMods.ResumeLayout(false);
            this.panel_ClientMods.PerformLayout();
            this.panel_ServerMods.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.ComboBox comboBox_Versions;
        private System.Windows.Forms.ListBox listBox_Version;
        private System.Windows.Forms.ListBox listBox_Mods;
        private System.Windows.Forms.Button button_addmod;
        private System.Windows.Forms.Button button_CVersion;
        private System.Windows.Forms.Button button_StartRaw;
        private System.Windows.Forms.Button button_Import;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_ToTray;
        private System.Windows.Forms.PictureBox pictureBox_ERlogo;
        private System.Windows.Forms.Label temp_name;
        private System.Windows.Forms.Panel panel_Mods;
        private System.Windows.Forms.Button button_Mods;
        private System.Windows.Forms.Panel panel_SideButt;
        private System.Windows.Forms.Button button_ServerMods;
        private System.Windows.Forms.Button button_ClientMods;
        private System.Windows.Forms.Panel panel_ServerMods;
        private System.Windows.Forms.Panel panel_ClientMods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedList_ServerMods;
        private System.Windows.Forms.CheckedListBox checkedList_ClientMods;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_mods;
        private System.Windows.Forms.Panel Resize_panel;
    }
}

