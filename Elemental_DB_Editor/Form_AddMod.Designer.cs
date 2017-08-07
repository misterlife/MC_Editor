namespace Elemental_DB_Editor
{
    partial class Form_AddMod
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddMod));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Addmod = new System.Windows.Forms.Button();
            this.checkBox_DirectMod = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mod File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direct download link:";
            // 
            // button_Addmod
            // 
            this.button_Addmod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Addmod.Location = new System.Drawing.Point(16, 95);
            this.button_Addmod.Name = "button_Addmod";
            this.button_Addmod.Size = new System.Drawing.Size(255, 23);
            this.button_Addmod.TabIndex = 4;
            this.button_Addmod.Text = "Submit";
            this.button_Addmod.UseVisualStyleBackColor = true;
            this.button_Addmod.Click += new System.EventHandler(this.button_Addmod_Click);
            // 
            // checkBox_DirectMod
            // 
            this.checkBox_DirectMod.AutoSize = true;
            this.checkBox_DirectMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_DirectMod.Location = new System.Drawing.Point(140, 3);
            this.checkBox_DirectMod.Name = "checkBox_DirectMod";
            this.checkBox_DirectMod.Size = new System.Drawing.Size(128, 17);
            this.checkBox_DirectMod.TabIndex = 5;
            this.checkBox_DirectMod.Text = "Add directly to Version";
            this.toolTip1.SetToolTip(this.checkBox_DirectMod, "This only adds it to the version without refreshing the list.\r\nKeep in mind if th" +
        "e list is refreshed before you commit\r\nthe mod will not be in the Version!");
            this.checkBox_DirectMod.UseVisualStyleBackColor = true;
            // 
            // Form_AddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 130);
            this.Controls.Add(this.checkBox_DirectMod);
            this.Controls.Add(this.button_Addmod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 169);
            this.MinimumSize = new System.Drawing.Size(300, 169);
            this.Name = "Form_AddMod";
            this.Text = "Add Mods";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AddMod_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Addmod;
        private System.Windows.Forms.CheckBox checkBox_DirectMod;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}