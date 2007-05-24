namespace Gassner.Partymusik.NET {
    partial class PartyMusicSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.listBoxDirectories = new System.Windows.Forms.ListBox();
            this.buttonAddDirectory = new System.Windows.Forms.Button();
            this.buttonDelDirectory = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.checkBoxAlwaysFullsize = new System.Windows.Forms.CheckBox();
            this.checkBoxPasswordProtection = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 370);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(116, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // button2
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(12, 341);
            this.buttonChangePassword.Name = "button2";
            this.buttonChangePassword.Size = new System.Drawing.Size(116, 23);
            this.buttonChangePassword.TabIndex = 1;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxDirectories
            // 
            this.listBoxDirectories.FormattingEnabled = true;
            this.listBoxDirectories.Location = new System.Drawing.Point(93, 25);
            this.listBoxDirectories.Name = "listBoxDirectories";
            this.listBoxDirectories.Size = new System.Drawing.Size(366, 238);
            this.listBoxDirectories.TabIndex = 3;
            // 
            // buttonAddDirectory
            // 
            this.buttonAddDirectory.Location = new System.Drawing.Point(12, 25);
            this.buttonAddDirectory.Name = "buttonAddDirectory";
            this.buttonAddDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDirectory.TabIndex = 4;
            this.buttonAddDirectory.Text = "Add Directory";
            this.buttonAddDirectory.UseVisualStyleBackColor = true;
            this.buttonAddDirectory.Click += new System.EventHandler(this.buttonAddDirectory_Click);
            // 
            // buttonDelDirectory
            // 
            this.buttonDelDirectory.Location = new System.Drawing.Point(12, 54);
            this.buttonDelDirectory.Name = "buttonDelDirectory";
            this.buttonDelDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonDelDirectory.TabIndex = 5;
            this.buttonDelDirectory.Text = "Remove";
            this.buttonDelDirectory.UseVisualStyleBackColor = true;
            this.buttonDelDirectory.Click += new System.EventHandler(this.buttonDelDirectory_Click);
            // 
            // label1
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(90, 9);
            this.labelInfo.Name = "label1";
            this.labelInfo.Size = new System.Drawing.Size(85, 13);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Musik Files roots";
            // 
            // checkBoxAlwaysFullsize
            // 
            this.checkBoxAlwaysFullsize.AutoSize = true;
            this.checkBoxAlwaysFullsize.Location = new System.Drawing.Point(12, 289);
            this.checkBoxAlwaysFullsize.Name = "checkBoxAlwaysFullsize";
            this.checkBoxAlwaysFullsize.Size = new System.Drawing.Size(96, 17);
            this.checkBoxAlwaysFullsize.TabIndex = 7;
            this.checkBoxAlwaysFullsize.Text = "Always Fullsize";
            this.checkBoxAlwaysFullsize.UseVisualStyleBackColor = true;
            this.checkBoxAlwaysFullsize.CheckedChanged += new System.EventHandler(this.checkBoxAlwaysFullsize_CheckedChanged);
            // 
            // checkBoxPasswordProtection
            // 
            this.checkBoxPasswordProtection.AutoSize = true;
            this.checkBoxPasswordProtection.Location = new System.Drawing.Point(12, 312);
            this.checkBoxPasswordProtection.Name = "checkBoxPasswordProtection";
            this.checkBoxPasswordProtection.Size = new System.Drawing.Size(123, 17);
            this.checkBoxPasswordProtection.TabIndex = 8;
            this.checkBoxPasswordProtection.Text = "Password Protection";
            this.checkBoxPasswordProtection.UseVisualStyleBackColor = true;
            this.checkBoxPasswordProtection.CheckedChanged += new System.EventHandler(this.checkBoxPasswordProtection_CheckedChanged);
            // 
            // PartyMusicSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 440);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxPasswordProtection);
            this.Controls.Add(this.checkBoxAlwaysFullsize);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonDelDirectory);
            this.Controls.Add(this.buttonAddDirectory);
            this.Controls.Add(this.listBoxDirectories);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PartyMusicSettings";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Shown += new System.EventHandler(this.PartyMusicSettings_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.ListBox listBoxDirectories;
        private System.Windows.Forms.Button buttonAddDirectory;
        private System.Windows.Forms.Button buttonDelDirectory;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.CheckBox checkBoxAlwaysFullsize;
        private System.Windows.Forms.CheckBox checkBoxPasswordProtection;
    }
}