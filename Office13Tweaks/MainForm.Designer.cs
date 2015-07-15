/*
 * Office13Tweaks Main Form Class
 * Copyright (C) 2013, Petros Kyladitis
 * 
 * This program is free software distributed under the GNU GPL 3,
 * for license details see at 'license.txt' file, distributed with
 * this project, or see at <http://www.gnu.org/licenses/>.
 */
 
namespace Office13Tweaks{
	partial class MainForm	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)	{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()	{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBoxTypingAnimationOff = new System.Windows.Forms.PictureBox();
			this.pictureBoxTypingAnimationOn = new System.Windows.Forms.PictureBox();
			this.labelTypingAnimation = new System.Windows.Forms.Label();
			this.labelNotInstalled = new System.Windows.Forms.Label();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelStartscreen = new System.Windows.Forms.Label();
			this.pictureBoxStartscreenOn = new System.Windows.Forms.PictureBox();
			this.pictureBoxStartscreenOff = new System.Windows.Forms.PictureBox();
			this.labelSkydrive = new System.Windows.Forms.Label();
			this.pictureBoxSkydriveOn = new System.Windows.Forms.PictureBox();
			this.pictureBoxSkydriveOff = new System.Windows.Forms.PictureBox();
			this.textBoxOutlookFolder = new System.Windows.Forms.TextBox();
			this.groupBoxOutlookFolder = new System.Windows.Forms.GroupBox();
			this.pictureBoxSearchOutlookFolder = new System.Windows.Forms.PictureBox();
			this.labelOutlookFolder = new System.Windows.Forms.Label();
			this.pictureBoxOutlookFolderOn = new System.Windows.Forms.PictureBox();
			this.pictureBoxOutlookFolderOff = new System.Windows.Forms.PictureBox();
			this.groupBoxSkydrive = new System.Windows.Forms.GroupBox();
			this.groupBoxWordStartScreen = new System.Windows.Forms.GroupBox();
			this.groupBoxTypingAnimation = new System.Windows.Forms.GroupBox();
			this.folderBrowserDialogAttachment = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTypingAnimationOff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTypingAnimationOn)).BeginInit();
			this.menuStripMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartscreenOn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartscreenOff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkydriveOn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkydriveOff)).BeginInit();
			this.groupBoxOutlookFolder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchOutlookFolder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutlookFolderOn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutlookFolderOff)).BeginInit();
			this.groupBoxSkydrive.SuspendLayout();
			this.groupBoxWordStartScreen.SuspendLayout();
			this.groupBoxTypingAnimation.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxTypingAnimationOff
			// 
			this.pictureBoxTypingAnimationOff.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxTypingAnimationOff.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTypingAnimationOff.Image")));
			this.pictureBoxTypingAnimationOff.Location = new System.Drawing.Point(6, 22);
			this.pictureBoxTypingAnimationOff.Name = "pictureBoxTypingAnimationOff";
			this.pictureBoxTypingAnimationOff.Size = new System.Drawing.Size(100, 40);
			this.pictureBoxTypingAnimationOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxTypingAnimationOff.TabIndex = 0;
			this.pictureBoxTypingAnimationOff.TabStop = false;
			this.pictureBoxTypingAnimationOff.Click += new System.EventHandler(this.PictureBoxTypingAnimationOffClick);
			// 
			// pictureBoxTypingAnimationOn
			// 
			this.pictureBoxTypingAnimationOn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxTypingAnimationOn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTypingAnimationOn.Image")));
			this.pictureBoxTypingAnimationOn.Location = new System.Drawing.Point(6, 22);
			this.pictureBoxTypingAnimationOn.Name = "pictureBoxTypingAnimationOn";
			this.pictureBoxTypingAnimationOn.Size = new System.Drawing.Size(100, 40);
			this.pictureBoxTypingAnimationOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxTypingAnimationOn.TabIndex = 1;
			this.pictureBoxTypingAnimationOn.TabStop = false;
			this.pictureBoxTypingAnimationOn.Click += new System.EventHandler(this.PictureBoxTypingAnimationOnClick);
			// 
			// labelTypingAnimation
			// 
			this.labelTypingAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelTypingAnimation.Location = new System.Drawing.Point(112, 22);
			this.labelTypingAnimation.Name = "labelTypingAnimation";
			this.labelTypingAnimation.Size = new System.Drawing.Size(256, 40);
			this.labelTypingAnimation.TabIndex = 2;
			this.labelTypingAnimation.Text = "The typing animation is now enabled";
			this.labelTypingAnimation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNotInstalled
			// 
			this.labelNotInstalled.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelNotInstalled.ForeColor = System.Drawing.Color.Red;
			this.labelNotInstalled.Location = new System.Drawing.Point(0, 27);
			this.labelNotInstalled.Name = "labelNotInstalled";
			this.labelNotInstalled.Size = new System.Drawing.Size(397, 348);
			this.labelNotInstalled.TabIndex = 4;
			this.labelNotInstalled.Text = "MS Office 2013 is not installed on your system. So, this program is useless to yo" +
			"u.";
			this.labelNotInstalled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(397, 24);
			this.menuStripMain.TabIndex = 5;
			this.menuStripMain.Text = "menuStripMain";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// labelStartscreen
			// 
			this.labelStartscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelStartscreen.Location = new System.Drawing.Point(115, 22);
			this.labelStartscreen.Name = "labelStartscreen";
			this.labelStartscreen.Size = new System.Drawing.Size(256, 40);
			this.labelStartscreen.TabIndex = 8;
			this.labelStartscreen.Text = "Applications Start Screen is now enabled";
			this.labelStartscreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxStartscreenOn
			// 
			this.pictureBoxStartscreenOn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxStartscreenOn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStartscreenOn.Image")));
			this.pictureBoxStartscreenOn.Location = new System.Drawing.Point(9, 22);
			this.pictureBoxStartscreenOn.Name = "pictureBoxStartscreenOn";
			this.pictureBoxStartscreenOn.Size = new System.Drawing.Size(100, 40);
			this.pictureBoxStartscreenOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxStartscreenOn.TabIndex = 7;
			this.pictureBoxStartscreenOn.TabStop = false;
			this.pictureBoxStartscreenOn.Click += new System.EventHandler(this.PictureBoxStartscreenOnClick);
			// 
			// pictureBoxStartscreenOff
			// 
			this.pictureBoxStartscreenOff.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxStartscreenOff.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStartscreenOff.Image")));
			this.pictureBoxStartscreenOff.Location = new System.Drawing.Point(9, 22);
			this.pictureBoxStartscreenOff.Name = "pictureBoxStartscreenOff";
			this.pictureBoxStartscreenOff.Size = new System.Drawing.Size(100, 40);
			this.pictureBoxStartscreenOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxStartscreenOff.TabIndex = 6;
			this.pictureBoxStartscreenOff.TabStop = false;
			this.pictureBoxStartscreenOff.Click += new System.EventHandler(this.PictureBoxStartscreenOffClick);
			// 
			// labelSkydrive
			// 
			this.labelSkydrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelSkydrive.Location = new System.Drawing.Point(115, 22);
			this.labelSkydrive.Name = "labelSkydrive";
			this.labelSkydrive.Size = new System.Drawing.Size(256, 40);
			this.labelSkydrive.TabIndex = 11;
			this.labelSkydrive.Text = "SkyDrive Pro from the Right-Click Context Menu is now enabled\r\n";
			this.labelSkydrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxSkydriveOn
			// 
			this.pictureBoxSkydriveOn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxSkydriveOn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSkydriveOn.Image")));
			this.pictureBoxSkydriveOn.Location = new System.Drawing.Point(9, 22);
			this.pictureBoxSkydriveOn.Name = "pictureBoxSkydriveOn";
			this.pictureBoxSkydriveOn.Size = new System.Drawing.Size(100, 40);
			this.pictureBoxSkydriveOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxSkydriveOn.TabIndex = 10;
			this.pictureBoxSkydriveOn.TabStop = false;
			this.pictureBoxSkydriveOn.Click += new System.EventHandler(this.PictureBoxSkydriveOnClick);
			// 
			// pictureBoxSkydriveOff
			// 
			this.pictureBoxSkydriveOff.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxSkydriveOff.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSkydriveOff.Image")));
			this.pictureBoxSkydriveOff.Location = new System.Drawing.Point(9, 22);
			this.pictureBoxSkydriveOff.Name = "pictureBoxSkydriveOff";
			this.pictureBoxSkydriveOff.Size = new System.Drawing.Size(100, 40);
			this.pictureBoxSkydriveOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxSkydriveOff.TabIndex = 9;
			this.pictureBoxSkydriveOff.TabStop = false;
			this.pictureBoxSkydriveOff.Click += new System.EventHandler(this.PictureBoxSkydriveOffClick);
			// 
			// textBoxOutlookFolder
			// 
			this.textBoxOutlookFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBoxOutlookFolder.Location = new System.Drawing.Point(6, 74);
			this.textBoxOutlookFolder.Name = "textBoxOutlookFolder";
			this.textBoxOutlookFolder.Size = new System.Drawing.Size(325, 26);
			this.textBoxOutlookFolder.TabIndex = 12;
			// 
			// groupBoxOutlookFolder
			// 
			this.groupBoxOutlookFolder.Controls.Add(this.pictureBoxSearchOutlookFolder);
			this.groupBoxOutlookFolder.Controls.Add(this.labelOutlookFolder);
			this.groupBoxOutlookFolder.Controls.Add(this.pictureBoxOutlookFolderOn);
			this.groupBoxOutlookFolder.Controls.Add(this.pictureBoxOutlookFolderOff);
			this.groupBoxOutlookFolder.Controls.Add(this.textBoxOutlookFolder);
			this.groupBoxOutlookFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.groupBoxOutlookFolder.Location = new System.Drawing.Point(11, 257);
			this.groupBoxOutlookFolder.Name = "groupBoxOutlookFolder";
			this.groupBoxOutlookFolder.Size = new System.Drawing.Size(373, 109);
			this.groupBoxOutlookFolder.TabIndex = 13;
			this.groupBoxOutlookFolder.TabStop = false;
			this.groupBoxOutlookFolder.Text = "Outlook Attachments";
			// 
			// pictureBoxSearchOutlookFolder
			// 
			this.pictureBoxSearchOutlookFolder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxSearchOutlookFolder.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearchOutlookFolder.Image")));
			this.pictureBoxSearchOutlookFolder.Location = new System.Drawing.Point(337, 68);
			this.pictureBoxSearchOutlookFolder.Name = "pictureBoxSearchOutlookFolder";
			this.pictureBoxSearchOutlookFolder.Size = new System.Drawing.Size(32, 32);
			this.pictureBoxSearchOutlookFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxSearchOutlookFolder.TabIndex = 14;
			this.pictureBoxSearchOutlookFolder.TabStop = false;
			this.pictureBoxSearchOutlookFolder.Click += new System.EventHandler(this.PictureBoxSearchOutlookFolderClick);
			// 
			// labelOutlookFolder
			// 
			this.labelOutlookFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelOutlookFolder.Location = new System.Drawing.Point(112, 25);
			this.labelOutlookFolder.Name = "labelOutlookFolder";
			this.labelOutlookFolder.Size = new System.Drawing.Size(257, 40);
			this.labelOutlookFolder.TabIndex = 15;
			this.labelOutlookFolder.Text = "Custom default attachments folder is now enabled";
			this.labelOutlookFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxOutlookFolderOn
			// 
			this.pictureBoxOutlookFolderOn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxOutlookFolderOn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOutlookFolderOn.Image")));
			this.pictureBoxOutlookFolderOn.Location = new System.Drawing.Point(6, 25);
			this.pictureBoxOutlookFolderOn.Name = "pictureBoxOutlookFolderOn";
			this.pictureBoxOutlookFolderOn.Size = new System.Drawing.Size(100, 40);
			this.pictureBoxOutlookFolderOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxOutlookFolderOn.TabIndex = 14;
			this.pictureBoxOutlookFolderOn.TabStop = false;
			this.pictureBoxOutlookFolderOn.Click += new System.EventHandler(this.PictureBoxOutlookFolderOnClick);
			// 
			// pictureBoxOutlookFolderOff
			// 
			this.pictureBoxOutlookFolderOff.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxOutlookFolderOff.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOutlookFolderOff.Image")));
			this.pictureBoxOutlookFolderOff.Location = new System.Drawing.Point(6, 25);
			this.pictureBoxOutlookFolderOff.Name = "pictureBoxOutlookFolderOff";
			this.pictureBoxOutlookFolderOff.Size = new System.Drawing.Size(100, 40);
			this.pictureBoxOutlookFolderOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxOutlookFolderOff.TabIndex = 13;
			this.pictureBoxOutlookFolderOff.TabStop = false;
			this.pictureBoxOutlookFolderOff.Click += new System.EventHandler(this.PictureBoxOutlookFolderOffClick);
			// 
			// groupBoxSkydrive
			// 
			this.groupBoxSkydrive.Controls.Add(this.pictureBoxSkydriveOn);
			this.groupBoxSkydrive.Controls.Add(this.pictureBoxSkydriveOff);
			this.groupBoxSkydrive.Controls.Add(this.labelSkydrive);
			this.groupBoxSkydrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.groupBoxSkydrive.Location = new System.Drawing.Point(11, 182);
			this.groupBoxSkydrive.Name = "groupBoxSkydrive";
			this.groupBoxSkydrive.Size = new System.Drawing.Size(373, 69);
			this.groupBoxSkydrive.TabIndex = 14;
			this.groupBoxSkydrive.TabStop = false;
			this.groupBoxSkydrive.Text = "Skydrive Pro";
			// 
			// groupBoxWordStartScreen
			// 
			this.groupBoxWordStartScreen.Controls.Add(this.pictureBoxStartscreenOn);
			this.groupBoxWordStartScreen.Controls.Add(this.pictureBoxStartscreenOff);
			this.groupBoxWordStartScreen.Controls.Add(this.labelStartscreen);
			this.groupBoxWordStartScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.groupBoxWordStartScreen.Location = new System.Drawing.Point(13, 105);
			this.groupBoxWordStartScreen.Name = "groupBoxWordStartScreen";
			this.groupBoxWordStartScreen.Size = new System.Drawing.Size(373, 71);
			this.groupBoxWordStartScreen.TabIndex = 15;
			this.groupBoxWordStartScreen.TabStop = false;
			this.groupBoxWordStartScreen.Text = "Applications Start Screen";
			// 
			// groupBoxTypingAnimation
			// 
			this.groupBoxTypingAnimation.Controls.Add(this.pictureBoxTypingAnimationOn);
			this.groupBoxTypingAnimation.Controls.Add(this.pictureBoxTypingAnimationOff);
			this.groupBoxTypingAnimation.Controls.Add(this.labelTypingAnimation);
			this.groupBoxTypingAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.groupBoxTypingAnimation.Location = new System.Drawing.Point(12, 27);
			this.groupBoxTypingAnimation.Name = "groupBoxTypingAnimation";
			this.groupBoxTypingAnimation.Size = new System.Drawing.Size(374, 72);
			this.groupBoxTypingAnimation.TabIndex = 16;
			this.groupBoxTypingAnimation.TabStop = false;
			this.groupBoxTypingAnimation.Text = "Typing Animation";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 376);
			this.Controls.Add(this.groupBoxTypingAnimation);
			this.Controls.Add(this.groupBoxWordStartScreen);
			this.Controls.Add(this.groupBoxOutlookFolder);
			this.Controls.Add(this.menuStripMain);
			this.Controls.Add(this.groupBoxSkydrive);
			this.Controls.Add(this.labelNotInstalled);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripMain;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Office13 Tweaks";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTypingAnimationOff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTypingAnimationOn)).EndInit();
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartscreenOn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartscreenOff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkydriveOn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkydriveOff)).EndInit();
			this.groupBoxOutlookFolder.ResumeLayout(false);
			this.groupBoxOutlookFolder.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchOutlookFolder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutlookFolderOn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutlookFolderOff)).EndInit();
			this.groupBoxSkydrive.ResumeLayout(false);
			this.groupBoxSkydrive.PerformLayout();
			this.groupBoxWordStartScreen.ResumeLayout(false);
			this.groupBoxWordStartScreen.PerformLayout();
			this.groupBoxTypingAnimation.ResumeLayout(false);
			this.groupBoxTypingAnimation.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogAttachment;
		private System.Windows.Forms.GroupBox groupBoxTypingAnimation;
		private System.Windows.Forms.GroupBox groupBoxWordStartScreen;
		private System.Windows.Forms.GroupBox groupBoxSkydrive;
		private System.Windows.Forms.PictureBox pictureBoxOutlookFolderOff;
		private System.Windows.Forms.PictureBox pictureBoxOutlookFolderOn;
		private System.Windows.Forms.Label labelOutlookFolder;
		private System.Windows.Forms.PictureBox pictureBoxSearchOutlookFolder;
		private System.Windows.Forms.GroupBox groupBoxOutlookFolder;
		private System.Windows.Forms.TextBox textBoxOutlookFolder;
		private System.Windows.Forms.PictureBox pictureBoxSkydriveOff;
		private System.Windows.Forms.PictureBox pictureBoxSkydriveOn;
		private System.Windows.Forms.Label labelSkydrive;
		private System.Windows.Forms.PictureBox pictureBoxStartscreenOff;
		private System.Windows.Forms.PictureBox pictureBoxStartscreenOn;
		private System.Windows.Forms.Label labelStartscreen;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.Label labelNotInstalled;
		private System.Windows.Forms.Label labelTypingAnimation;
		private System.Windows.Forms.PictureBox pictureBoxTypingAnimationOn;
		private System.Windows.Forms.PictureBox pictureBoxTypingAnimationOff;
	}
}
