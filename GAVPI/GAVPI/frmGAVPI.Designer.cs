﻿namespace GAVPI
{
    partial class frmGAVPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGAVPI));
            this.mainStatStrip = new System.Windows.Forms.StatusStrip();
            this.btmStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStripProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lstMainHearing = new System.Windows.Forms.ListView();
            this.RecognizedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMainListen = new System.Windows.Forms.Button();
            this.btnMainStop = new System.Windows.Forms.Button();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatStrip
            // 
            this.mainStatStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btmStripStatus});
            this.mainStatStrip.Location = new System.Drawing.Point(0, 218);
            this.mainStatStrip.Name = "mainStatStrip";
            this.mainStatStrip.Size = new System.Drawing.Size(675, 22);
            this.mainStatStrip.TabIndex = 0;
            this.mainStatStrip.Text = "statusStrip1";
            // 
            // btmStripStatus
            // 
            this.btmStripStatus.Name = "btmStripStatus";
            this.btmStripStatus.Size = new System.Drawing.Size(75, 17);
            this.btmStripStatus.Text = "NOT LISTENING";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStripFile,
            this.mainStripProfile,
            this.mainStripSettings,
            this.mainStripAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "mainMenuStrip";
            // 
            // mainStripFile
            // 
            this.mainStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainStripFile.Name = "mainStripFile";
            this.mainStripFile.Size = new System.Drawing.Size(36, 20);
            this.mainStripFile.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Open Profile";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainStripProfile
            // 
            this.mainStripProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem});
            this.mainStripProfile.Name = "mainStripProfile";
            this.mainStripProfile.Size = new System.Drawing.Size(50, 20);
            this.mainStripProfile.Text = "Profile";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Modify";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // mainStripSettings
            // 
            this.mainStripSettings.Name = "mainStripSettings";
            this.mainStripSettings.Size = new System.Drawing.Size(55, 20);
            this.mainStripSettings.Text = "Settings";
            this.mainStripSettings.Click += new System.EventHandler(this.mainStripSettings_Click);
            // 
            // mainStripAbout
            // 
            this.mainStripAbout.Name = "mainStripAbout";
            this.mainStripAbout.Size = new System.Drawing.Size(47, 20);
            this.mainStripAbout.Text = "About";
            this.mainStripAbout.Click += new System.EventHandler(this.mainStripAbout_Click);
            // 
            // lstMainHearing
            // 
            this.lstMainHearing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMainHearing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RecognizedColumn});
            this.lstMainHearing.GridLines = true;
            this.lstMainHearing.Location = new System.Drawing.Point(12, 27);
            this.lstMainHearing.Name = "lstMainHearing";
            this.lstMainHearing.Size = new System.Drawing.Size(545, 180);
            this.lstMainHearing.TabIndex = 2;
            this.lstMainHearing.UseCompatibleStateImageBehavior = false;
            this.lstMainHearing.View = System.Windows.Forms.View.Details;
            // 
            // RecognizedColumn
            // 
            this.RecognizedColumn.Text = "Recognized";
            this.RecognizedColumn.Width = 94;
            // 
            // btnMainListen
            // 
            this.btnMainListen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainListen.Enabled = false;
            this.btnMainListen.Location = new System.Drawing.Point(563, 27);
            this.btnMainListen.Name = "btnMainListen";
            this.btnMainListen.Size = new System.Drawing.Size(94, 23);
            this.btnMainListen.TabIndex = 3;
            this.btnMainListen.Text = "Listen";
            this.btnMainListen.UseVisualStyleBackColor = true;
            this.btnMainListen.Click += new System.EventHandler(this.btnMainListen_Click);
            // 
            // btnMainStop
            // 
            this.btnMainStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainStop.Enabled = false;
            this.btnMainStop.Location = new System.Drawing.Point(563, 56);
            this.btnMainStop.Name = "btnMainStop";
            this.btnMainStop.Size = new System.Drawing.Size(94, 23);
            this.btnMainStop.TabIndex = 4;
            this.btnMainStop.Text = "Stop";
            this.btnMainStop.UseVisualStyleBackColor = true;
            this.btnMainStop.Click += new System.EventHandler(this.btnMainStop_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // frmGAVPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(675, 240);
            this.Controls.Add(this.btnMainStop);
            this.Controls.Add(this.btnMainListen);
            this.Controls.Add(this.lstMainHearing);
            this.Controls.Add(this.mainStatStrip);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(685, 270);
            this.Name = "frmGAVPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAVPI : Graphical AVPI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGAVPI_FormClosing);
            this.mainStatStrip.ResumeLayout(false);
            this.mainStatStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainStripFile;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainStripSettings;
        private System.Windows.Forms.ToolStripMenuItem mainStripAbout;
        private System.Windows.Forms.ToolStripMenuItem mainStripProfile;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ListView lstMainHearing;
        private System.Windows.Forms.Button btnMainListen;
        private System.Windows.Forms.Button btnMainStop;
        private System.Windows.Forms.ColumnHeader RecognizedColumn;
        private System.Windows.Forms.ToolStripStatusLabel btmStripStatus;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

