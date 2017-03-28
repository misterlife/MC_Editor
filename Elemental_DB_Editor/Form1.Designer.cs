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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_ToTray = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.temp_name = new System.Windows.Forms.Label();
            this.pictureBox_ERlogo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ERlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(104, 99);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(89, 21);
            this.button_Login.TabIndex = 1;
            this.button_Login.Text = "MySQL";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_submit
            // 
            this.button_submit.Enabled = false;
            this.button_submit.Location = new System.Drawing.Point(44, 99);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(149, 21);
            this.button_submit.TabIndex = 3;
            this.button_submit.Text = "Commit Modlist";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Visible = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // comboBox_Versions
            // 
            this.comboBox_Versions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Versions.Enabled = false;
            this.comboBox_Versions.FormattingEnabled = true;
            this.comboBox_Versions.Location = new System.Drawing.Point(210, 100);
            this.comboBox_Versions.Name = "comboBox_Versions";
            this.comboBox_Versions.Size = new System.Drawing.Size(149, 21);
            this.comboBox_Versions.TabIndex = 4;
            this.comboBox_Versions.SelectedValueChanged += new System.EventHandler(this.comboBox_Versions_SelectedValueChanged);
            // 
            // listBox_Version
            // 
            this.listBox_Version.Enabled = false;
            this.listBox_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listBox_Version.FormattingEnabled = true;
            this.listBox_Version.ItemHeight = 18;
            this.listBox_Version.Location = new System.Drawing.Point(210, 127);
            this.listBox_Version.Name = "listBox_Version";
            this.listBox_Version.Size = new System.Drawing.Size(180, 274);
            this.listBox_Version.Sorted = true;
            this.listBox_Version.TabIndex = 5;
            this.listBox_Version.DoubleClick += new System.EventHandler(this.listBox_Version_DoubleClick);
            // 
            // listBox_Mods
            // 
            this.listBox_Mods.Enabled = false;
            this.listBox_Mods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listBox_Mods.FormattingEnabled = true;
            this.listBox_Mods.ItemHeight = 18;
            this.listBox_Mods.Location = new System.Drawing.Point(13, 126);
            this.listBox_Mods.Name = "listBox_Mods";
            this.listBox_Mods.Size = new System.Drawing.Size(180, 274);
            this.listBox_Mods.Sorted = true;
            this.listBox_Mods.TabIndex = 6;
            this.listBox_Mods.DoubleClick += new System.EventHandler(this.listBox_Mods_DoubleClick);
            // 
            // button_addmod
            // 
            this.button_addmod.Location = new System.Drawing.Point(13, 99);
            this.button_addmod.Name = "button_addmod";
            this.button_addmod.Size = new System.Drawing.Size(25, 21);
            this.button_addmod.TabIndex = 7;
            this.button_addmod.Text = "+";
            this.button_addmod.UseVisualStyleBackColor = true;
            this.button_addmod.Visible = false;
            this.button_addmod.Click += new System.EventHandler(this.button_addmod_Click);
            // 
            // button_CVersion
            // 
            this.button_CVersion.Enabled = false;
            this.button_CVersion.Location = new System.Drawing.Point(365, 100);
            this.button_CVersion.Name = "button_CVersion";
            this.button_CVersion.Size = new System.Drawing.Size(25, 21);
            this.button_CVersion.TabIndex = 8;
            this.button_CVersion.Text = "[ ]";
            this.button_CVersion.UseVisualStyleBackColor = true;
            this.button_CVersion.Click += new System.EventHandler(this.button_CVersion_Click);
            // 
            // button_StartRaw
            // 
            this.button_StartRaw.Location = new System.Drawing.Point(13, 99);
            this.button_StartRaw.Name = "button_StartRaw";
            this.button_StartRaw.Size = new System.Drawing.Size(89, 21);
            this.button_StartRaw.TabIndex = 9;
            this.button_StartRaw.Text = "Raw";
            this.button_StartRaw.UseVisualStyleBackColor = true;
            this.button_StartRaw.Click += new System.EventHandler(this.button_StartRaw_Click);
            // 
            // button_Import
            // 
            this.button_Import.Location = new System.Drawing.Point(41, 99);
            this.button_Import.Name = "button_Import";
            this.button_Import.Size = new System.Drawing.Size(73, 21);
            this.button_Import.TabIndex = 10;
            this.button_Import.Text = "Import";
            this.button_Import.UseVisualStyleBackColor = true;
            this.button_Import.Visible = false;
            this.button_Import.Click += new System.EventHandler(this.button_Import_Click);
            // 
            // button_Export
            // 
            this.button_Export.Location = new System.Drawing.Point(120, 99);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(73, 21);
            this.button_Export.TabIndex = 11;
            this.button_Export.Text = "Export";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Visible = false;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 80);
            this.panel2.TabIndex = 20;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Controls.Add(this.button_ToTray, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Close, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.temp_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_ERlogo, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1087, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button_ToTray
            // 
            this.button_ToTray.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ToTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.button_ToTray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ToTray.BackgroundImage")));
            this.button_ToTray.FlatAppearance.BorderSize = 0;
            this.button_ToTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ToTray.Location = new System.Drawing.Point(963, 5);
            this.button_ToTray.Name = "button_ToTray";
            this.button_ToTray.Size = new System.Drawing.Size(50, 50);
            this.button_ToTray.TabIndex = 27;
            this.button_ToTray.UseVisualStyleBackColor = false;
            // 
            // button_Close
            // 
            this.button_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.button_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Close.BackgroundImage")));
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(1022, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(50, 50);
            this.button_Close.TabIndex = 29;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // temp_name
            // 
            this.temp_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.temp_name.AutoSize = true;
            this.temp_name.BackColor = System.Drawing.Color.Transparent;
            this.temp_name.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_name.ForeColor = System.Drawing.Color.SeaShell;
            this.temp_name.Location = new System.Drawing.Point(73, 17);
            this.temp_name.Name = "temp_name";
            this.temp_name.Size = new System.Drawing.Size(179, 25);
            this.temp_name.TabIndex = 15;
            this.temp_name.Text = "Elemental launcher ";
            // 
            // pictureBox_ERlogo
            // 
            this.pictureBox_ERlogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ERlogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ERlogo.Image")));
            this.pictureBox_ERlogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_ERlogo.MaximumSize = new System.Drawing.Size(64, 64);
            this.pictureBox_ERlogo.MinimumSize = new System.Drawing.Size(64, 64);
            this.pictureBox_ERlogo.Name = "pictureBox_ERlogo";
            this.pictureBox_ERlogo.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_ERlogo.TabIndex = 26;
            this.pictureBox_ERlogo.TabStop = false;
            // 
            // ER_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.button_Import);
            this.Controls.Add(this.button_StartRaw);
            this.Controls.Add(this.button_CVersion);
            this.Controls.Add(this.button_addmod);
            this.Controls.Add(this.listBox_Mods);
            this.Controls.Add(this.listBox_Version);
            this.Controls.Add(this.comboBox_Versions);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.button_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1100, 600);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "ER_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERealms Editor";
            this.Load += new System.EventHandler(this.ER_Form_Load);
            this.SizeChanged += new System.EventHandler(this.ER_Form_SizeChanged);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ERlogo)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_ToTray;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label temp_name;
        private System.Windows.Forms.PictureBox pictureBox_ERlogo;
    }
}

