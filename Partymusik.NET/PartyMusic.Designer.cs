namespace Gassner.Partymusik.NET {
    partial class PartyMusic {
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonTopMost = new System.Windows.Forms.Button();
            this.labelHits = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.labelFilesInBuffer = new System.Windows.Forms.Label();
            this.textBoxHits = new System.Windows.Forms.TextBox();
            this.textBoxFilesInBuffer = new System.Windows.Forms.TextBox();
            this.buttonStartPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 38);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(174, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Warning: First Search will take longer!";
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(12, 12);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(174, 20);
            this.textBoxQuery.TabIndex = 2;
            this.textBoxQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxQuery_KeyDown);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(192, 12);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(600, 394);
            this.listBoxResult.TabIndex = 3;
            this.listBoxResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxResult_MouseDown);
            // 
            // buttonTopMost
            // 
            this.buttonTopMost.Location = new System.Drawing.Point(12, 385);
            this.buttonTopMost.Name = "buttonTopMost";
            this.buttonTopMost.Size = new System.Drawing.Size(174, 23);
            this.buttonTopMost.TabIndex = 4;
            this.buttonTopMost.Text = "Top";
            this.buttonTopMost.UseVisualStyleBackColor = true;
            this.buttonTopMost.Click += new System.EventHandler(this.buttonTopMost_Click);
            // 
            // labelHits
            // 
            this.labelHits.AutoSize = true;
            this.labelHits.Location = new System.Drawing.Point(12, 215);
            this.labelHits.Name = "labelHits";
            this.labelHits.Size = new System.Drawing.Size(28, 13);
            this.labelHits.TabIndex = 5;
            this.labelHits.Text = "Hits:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 67);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(174, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 6;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(12, 281);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(174, 23);
            this.buttonSettings.TabIndex = 7;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // labelFilesInBuffer
            // 
            this.labelFilesInBuffer.AutoSize = true;
            this.labelFilesInBuffer.Location = new System.Drawing.Point(12, 241);
            this.labelFilesInBuffer.Name = "labelFilesInBuffer";
            this.labelFilesInBuffer.Size = new System.Drawing.Size(72, 13);
            this.labelFilesInBuffer.TabIndex = 8;
            this.labelFilesInBuffer.Text = "Files in buffer:";
            // 
            // textBoxHits
            // 
            this.textBoxHits.Enabled = false;
            this.textBoxHits.Location = new System.Drawing.Point(86, 212);
            this.textBoxHits.Name = "textBoxHits";
            this.textBoxHits.Size = new System.Drawing.Size(100, 20);
            this.textBoxHits.TabIndex = 9;
            this.textBoxHits.Text = "0";
            // 
            // textBoxFilesInBuffer
            // 
            this.textBoxFilesInBuffer.Enabled = false;
            this.textBoxFilesInBuffer.Location = new System.Drawing.Point(86, 238);
            this.textBoxFilesInBuffer.Name = "textBoxFilesInBuffer";
            this.textBoxFilesInBuffer.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilesInBuffer.TabIndex = 10;
            this.textBoxFilesInBuffer.Text = "0";
            // 
            // buttonStartPlayer
            // 
            this.buttonStartPlayer.Location = new System.Drawing.Point(12, 310);
            this.buttonStartPlayer.Name = "buttonStartPlayer";
            this.buttonStartPlayer.Size = new System.Drawing.Size(174, 23);
            this.buttonStartPlayer.TabIndex = 11;
            this.buttonStartPlayer.Text = "Start Player";
            this.buttonStartPlayer.UseVisualStyleBackColor = true;
            this.buttonStartPlayer.Click += new System.EventHandler(this.buttonStartPlayer_Click);
            // 
            // PartyMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 420);
            this.Controls.Add(this.buttonStartPlayer);
            this.Controls.Add(this.textBoxFilesInBuffer);
            this.Controls.Add(this.textBoxHits);
            this.Controls.Add(this.labelFilesInBuffer);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelHits);
            this.Controls.Add(this.buttonTopMost);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Name = "PartyMusic";
            this.Text = "Partymusik.NET 1.3                        by Gassi the real Oger";
            this.Load += new System.EventHandler(this.PartyMusic_Load);
            this.SizeChanged += new System.EventHandler(this.PartyMusic_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PartyMusic_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonTopMost;
        private System.Windows.Forms.Label labelHits;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelFilesInBuffer;
        private System.Windows.Forms.TextBox textBoxHits;
        private System.Windows.Forms.TextBox textBoxFilesInBuffer;
        private System.Windows.Forms.Button buttonStartPlayer;
    }
}

