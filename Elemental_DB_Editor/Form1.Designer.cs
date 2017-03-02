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
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(98, 4);
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
            this.button_submit.Location = new System.Drawing.Point(38, 4);
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
            this.comboBox_Versions.Location = new System.Drawing.Point(204, 5);
            this.comboBox_Versions.Name = "comboBox_Versions";
            this.comboBox_Versions.Size = new System.Drawing.Size(149, 21);
            this.comboBox_Versions.TabIndex = 4;
            this.comboBox_Versions.SelectedValueChanged += new System.EventHandler(this.comboBox_Versions_SelectedValueChanged);
            // 
            // listBox_Version
            // 
            this.listBox_Version.Enabled = false;
            this.listBox_Version.FormattingEnabled = true;
            this.listBox_Version.Location = new System.Drawing.Point(204, 31);
            this.listBox_Version.Name = "listBox_Version";
            this.listBox_Version.Size = new System.Drawing.Size(180, 290);
            this.listBox_Version.Sorted = true;
            this.listBox_Version.TabIndex = 5;
            this.listBox_Version.DoubleClick += new System.EventHandler(this.listBox_Version_DoubleClick);
            // 
            // listBox_Mods
            // 
            this.listBox_Mods.Enabled = false;
            this.listBox_Mods.FormattingEnabled = true;
            this.listBox_Mods.Location = new System.Drawing.Point(7, 31);
            this.listBox_Mods.Name = "listBox_Mods";
            this.listBox_Mods.Size = new System.Drawing.Size(180, 290);
            this.listBox_Mods.Sorted = true;
            this.listBox_Mods.TabIndex = 6;
            this.listBox_Mods.DoubleClick += new System.EventHandler(this.listBox_Mods_DoubleClick);
            // 
            // button_addmod
            // 
            this.button_addmod.Location = new System.Drawing.Point(7, 4);
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
            this.button_CVersion.Location = new System.Drawing.Point(359, 5);
            this.button_CVersion.Name = "button_CVersion";
            this.button_CVersion.Size = new System.Drawing.Size(25, 21);
            this.button_CVersion.TabIndex = 8;
            this.button_CVersion.Text = "[ ]";
            this.button_CVersion.UseVisualStyleBackColor = true;
            this.button_CVersion.Click += new System.EventHandler(this.button_CVersion_Click);
            // 
            // button_StartRaw
            // 
            this.button_StartRaw.Location = new System.Drawing.Point(7, 4);
            this.button_StartRaw.Name = "button_StartRaw";
            this.button_StartRaw.Size = new System.Drawing.Size(89, 21);
            this.button_StartRaw.TabIndex = 9;
            this.button_StartRaw.Text = "Raw";
            this.button_StartRaw.UseVisualStyleBackColor = true;
            this.button_StartRaw.Click += new System.EventHandler(this.button_StartRaw_Click);
            // 
            // button_Import
            // 
            this.button_Import.Location = new System.Drawing.Point(35, 4);
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
            this.button_Export.Location = new System.Drawing.Point(114, 4);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(73, 21);
            this.button_Export.TabIndex = 11;
            this.button_Export.Text = "Export";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Visible = false;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // ER_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 324);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(406, 363);
            this.Name = "ER_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERealms Editor";
            this.Load += new System.EventHandler(this.ER_Form_Load);
            this.SizeChanged += new System.EventHandler(this.ER_Form_SizeChanged);
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
    }
}

