/*
 * Office13Tweaks Main Form Class
 * Copyright (C) 2013, Petros Kyladitis
 * 
 * This program is free software distributed under the GNU GPL 3,
 * for license details see at 'license.txt' file, distributed with
 * this project, or see at <http://www.gnu.org/licenses/>.
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics ;
using System.IO ;

namespace Office13Tweaks {
	
	public partial class MainForm : Form {
		public MainForm() {
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent() ;
		}
		
		// constant variables representing registry keys and value names
		private const string MSO13_KEY = "Software\\Microsoft\\Office\\15.0" ;
		private readonly string GRAPHICS_KEY = MSO13_KEY + "\\Common\\Graphics" ;
		private readonly string GENERAL_KEY = MSO13_KEY + "\\Common\\General" ;
		private readonly string OUTLOOK_OPTIONS_KEY = MSO13_KEY + "\\Outlook\\Options" ;
		private readonly string SKYDRIVE_MENU_KEY = "\\AllFilesystemObjects\\shell\\SPFS.ContextMenu" ;
		private const string ANIMATION_VALUE = "DisableAnimations" ;
		private const string BOOTSCREEN_VALUE = "DisableBootToOfficeStart" ;
		private const string ATTACHMENT_SAVE_LOCATION_VALUE = "DefaultPath" ;
		
		// constant variables representing application data folder and filenames
		private static readonly string APP_DATA_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\multiPetros\\Office13Tweaks" ;
		private readonly string SKYDRIVE_REG_FILE_BACKUP = APP_DATA_FOLDER + "\\skydrive.reg" ;
		
		// constant labels strings
		private const string ANIMATION_LABEL_TEXT = "The typing animation is now " ;
		private const string START_SCREEN_LABEL_TEXT = "Applications Start Screen is now  " ;
		private const string SKYDRIVE_LABEL_TEXT = "SkyDrive Pro from the Right-Click Context Menu is now " ;
		private const string OUTLOOK_LABEL_TEXT = "Custom default attachments folder is now " ;
		private const string ENABLED_TEXT = "enabled" ;
		private const string DISABLED_TEXT = "disabled" ;
		
		void MainFormLoad(object sender, EventArgs e){
			try{
				//if office 2013 is not installed, hide controls and show message
				if(!IsOffice13Installed()){
					groupBoxOutlookFolder.Visible = false ;
					groupBoxSkydrive.Visible = false ;
					groupBoxTypingAnimation.Visible = false ;
					groupBoxWordStartScreen.Visible = false ;
					labelNotInstalled.Visible = true ;
					this.Refresh() ;
					return ;
				}else{
					labelNotInstalled.Visible = false ;
				}
				
				//check typing animation and set on/off state
				if(GetAnimation()){
					ChangeState(pictureBoxTypingAnimationOff, pictureBoxTypingAnimationOn, labelTypingAnimation, ANIMATION_LABEL_TEXT + ENABLED_TEXT) ;
				}
				else{
					ChangeState(pictureBoxTypingAnimationOn, pictureBoxTypingAnimationOff, labelTypingAnimation, ANIMATION_LABEL_TEXT + DISABLED_TEXT) ;
				}

				//check apps start screen and set on/off state
				if(GetStartScreen()){
					ChangeState(pictureBoxStartscreenOff, pictureBoxStartscreenOn, labelStartscreen, START_SCREEN_LABEL_TEXT + ENABLED_TEXT) ;			
				}
				else{
					ChangeState(pictureBoxStartscreenOn, pictureBoxStartscreenOff, labelStartscreen, START_SCREEN_LABEL_TEXT + DISABLED_TEXT) ;			
				}
				
				//check skydrive context menu and set on/off state
				if(GetSkydriveKeys()){
					ChangeState(pictureBoxSkydriveOff, pictureBoxSkydriveOn, labelSkydrive, SKYDRIVE_LABEL_TEXT + ENABLED_TEXT) ;
				}else{
					ChangeState(pictureBoxSkydriveOn, pictureBoxSkydriveOff, labelSkydrive, SKYDRIVE_LABEL_TEXT + DISABLED_TEXT) ;
				}
				
				//check outlook custom attachments folder and set on/off state
				string attachmentLocation = GetAttachmentSaveLocation() ;
				if(attachmentLocation == null){
					ChangeState(pictureBoxOutlookFolderOn, pictureBoxOutlookFolderOff, labelOutlookFolder, OUTLOOK_LABEL_TEXT + DISABLED_TEXT) ;					
				}
				else{
					ChangeState(pictureBoxOutlookFolderOff, pictureBoxOutlookFolderOn, labelOutlookFolder, OUTLOOK_LABEL_TEXT + ENABLED_TEXT) ;
					textBoxOutlookFolder.Text = attachmentLocation ;					
				}
				
							
			}catch(Exception exc){
				//on error hide controls and show message
				ShowError(exc.Message) ;
				labelNotInstalled.Text = "Can't read from registry" ;
				groupBoxOutlookFolder.Visible = false ;
				groupBoxSkydrive.Visible = false ;
				groupBoxTypingAnimation.Visible = false ;
				groupBoxWordStartScreen.Visible = false ;					
				labelNotInstalled.Visible = true ;
				this.Refresh() ;				
			}
		}
		
		//check if MSO2013 is installed or not
		private bool IsOffice13Installed(){
			RegistryKey officeKey = Registry.CurrentUser.OpenSubKey(MSO13_KEY) ;
			if(officeKey != null){
				officeKey.Close() ;
				return true ;
			}
			return false ;
		}
		
		//check if typing animation is enabled or not
		private bool GetAnimation(){
			RegistryKey animationKey = Registry.CurrentUser.OpenSubKey(GRAPHICS_KEY) ;			
			if(animationKey == null) //if key not found in enabled
				return true ;
			object animationValueObj = animationKey.GetValue(ANIMATION_VALUE) ;
			animationKey.Close() ;
			if(animationValueObj == null) //if value not found is enabled
				return true ;
			int animationValue ;
			//if value is integer and 0 is not enabled, else it is
			if(int.TryParse(animationValueObj.ToString(), out animationValue) && animationValue == 0)
				return true ;
			return false ;
		}
		
		//set apropriate value to registry key for typing animationn(1 for disable, 0 for enable)
		private void SetAnimation(bool disabled){
			int val = disabled ? 0 : 1 ;
			RegistryKey animationKey = Registry.CurrentUser.CreateSubKey(GRAPHICS_KEY) ;
			animationKey.SetValue(ANIMATION_VALUE, val, RegistryValueKind.DWord) ;
			animationKey.Close() ;
		}
		
		//check if apps start screen is enabled or not
		private bool GetStartScreen(){
			RegistryKey startScreenKey = Registry.CurrentUser.OpenSubKey(GENERAL_KEY) ;			
			if(startScreenKey == null) //if key not found in enabled
				return true ;
			object startScreenValueObj = startScreenKey.GetValue(BOOTSCREEN_VALUE) ;
			startScreenKey.Close() ;
			if(startScreenValueObj == null) //if value not found is enabled
				return true ;
			int startScreenValue ;
			//if value is integer and 0 is not enabled, else it is
			if(int.TryParse(startScreenValueObj.ToString(), out startScreenValue) && startScreenValue == 0)
				return true ;
			return false ;
		}
		
		//set apropriate value to registry key for apps start screen (1 for disable, 0 for enable)
		private void SetStartScreen(bool disabled){
			int val = disabled ? 0 : 1 ;
			RegistryKey animationKey = Registry.CurrentUser.CreateSubKey(GENERAL_KEY) ;
			animationKey.SetValue(BOOTSCREEN_VALUE, val, RegistryValueKind.DWord) ;
			animationKey.Close() ;
		}

		//check if custom outlook attachments folder is enabled or not
		private string GetAttachmentSaveLocation(){
			RegistryKey attachmentKey = Registry.CurrentUser.OpenSubKey(OUTLOOK_OPTIONS_KEY) ;			
			if(attachmentKey == null) //if key not found in enabled
				return null ;
			object attachmentValueObj = attachmentKey.GetValue(ATTACHMENT_SAVE_LOCATION_VALUE) ;
			attachmentKey.Close() ;
			if(attachmentValueObj == null) //if value not found is enabled
				return null ;
			else
				return attachmentValueObj.ToString() ;
		}
		
		//set registry value, for custom outlook attachments folder
		private void SetAttachmentSaveLocation(string location){
			RegistryKey animationKey = Registry.CurrentUser.CreateSubKey(OUTLOOK_OPTIONS_KEY) ;
			animationKey.SetValue(ATTACHMENT_SAVE_LOCATION_VALUE, location, RegistryValueKind.String) ;
			animationKey.Close() ;
		}
		
		//delete registry value, to disable outlook attachments folder
		private void DelAttachmentSaveLocation(){
			RegistryKey attachmentsKey = Registry.CurrentUser.OpenSubKey(OUTLOOK_OPTIONS_KEY, true) ;
			if(attachmentsKey != null){
				attachmentsKey.DeleteValue(ATTACHMENT_SAVE_LOCATION_VALUE) ;
				attachmentsKey.Close() ;
			}
		}
		
		//save skydrive registry entries to a file
		private bool SaveSkydriveKeys(string filePath){
			string dirPath = Path.GetDirectoryName(filePath) ;
			
			//create app data directory if not exist
			if(!Directory.Exists(dirPath)){
				Directory.CreateDirectory(dirPath) ;
			}
			
			//if .reg file exist, delete it
			if(File.Exists(filePath)){
				File.Delete(filePath) ;
			}
			
			//backup registry entries to app data dir, using regedit tool
			Process regeditProc = new Process() ;
			regeditProc.StartInfo.FileName = "regedit.exe" ;
			regeditProc.StartInfo.Arguments = "/e \"" + filePath + "\" \"HKEY_CLASSES_ROOT" + SKYDRIVE_MENU_KEY + "\"" ;
			regeditProc.Start() ;
			regeditProc.WaitForExit() ;
			
			//if .reg file created return true (as done), false (as fail)
			if(File.Exists(filePath)){
				return true ;
			}else{
				return false ;
			}
		}
		
		//restore skydrive registry keys from a .reg file
		private void RestoreSkydriveKeys(string filePath){
			Process regeditProc = new Process() ;
			regeditProc.StartInfo.FileName = "regedit.exe" ;
			regeditProc.StartInfo.Arguments = "/s " + filePath ;
			regeditProc.Start() ;
			regeditProc.WaitForExit() ;	
			//TODO use regeditProc.ExitCode to determinate if done or error
		}
		
		//delete skydrive context menu registry entries
		//return true if done, false if key not exist
		private bool DelSkydriveKeys(){
			RegistryKey skydriveKey = Registry.ClassesRoot.OpenSubKey(SKYDRIVE_MENU_KEY) ;
			if(skydriveKey == null)
				return false ;
			skydriveKey.Close() ;
			Registry.ClassesRoot.DeleteSubKeyTree(SKYDRIVE_MENU_KEY) ;
			return true ;
		}
		
		//check if skydrive context menu is enabled
		private bool GetSkydriveKeys(){
			RegistryKey skydriveKey = Registry.ClassesRoot.OpenSubKey(SKYDRIVE_MENU_KEY) ;
			if(skydriveKey == null){
				return false ;
			}
			skydriveKey.Close() ;
			return true ;
		}
		
		//change the on/off state
		private void ChangeState(PictureBox pictureBoxOff, PictureBox pictureBoxOn, Label labelState, string labelText){
			pictureBoxOff.Visible = false ;
			pictureBoxOn.Visible = true ;
			labelState.Text = labelText ;
		}
		
		//show message box with the error message
		private void ShowError(string message){
			MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
		}
		
		//show folder select box and set the selected folder to text box
		void PictureBoxSearchOutlookFolderClick(object sender, EventArgs e){
			folderBrowserDialogAttachment.ShowDialog() ;
			textBoxOutlookFolder.Text = folderBrowserDialogAttachment.SelectedPath ;
		}

		//show program info		
		void AboutToolStripMenuItemClick(object sender, EventArgs e){
			MessageBox.Show("Office13 Tweaks - ver 2.0\nA simple utility for MS Office 2013 Tweaking\nFor updates check at: <http://www.multipetros.gr/>\nCopyright (c) 2013, Petros Kyladitis\n\nThis program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.\n\nThis program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.\n\nYou should have received a copy of the GNU General Public License along with this program.  If not, see <http://www.gnu.org/licenses/>", "About...", MessageBoxButtons.OK, MessageBoxIcon.Information) ;		}

		//exit the program
		void ExitToolStripMenuItemClick(object sender, System.EventArgs e){
			Application.Exit() ;
		}
		
		//disable typing animation
		void PictureBoxTypingAnimationOnClick(object sender, EventArgs e){
			try {
				SetAnimation(false) ;
			} catch (Exception exc) {
				ShowError(exc.Message) ;
				return ;
			}
			ChangeState(pictureBoxTypingAnimationOn, pictureBoxTypingAnimationOff, labelTypingAnimation, ANIMATION_LABEL_TEXT + DISABLED_TEXT) ;
		}
		
		//enable typing animation
		void PictureBoxTypingAnimationOffClick(object sender, EventArgs e){
			try {
				SetAnimation(true) ;
			} catch (Exception exc) {
				ShowError(exc.Message) ;
				return ;
			}
			ChangeState(pictureBoxTypingAnimationOff, pictureBoxTypingAnimationOn, labelTypingAnimation, ANIMATION_LABEL_TEXT + ENABLED_TEXT) ;
		}
		
		//disable applications start screen
		void PictureBoxStartscreenOnClick(object sender, EventArgs e){
			try {
				SetStartScreen(false) ;
			} catch (Exception exc) {
				ShowError(exc.Message) ;
				return ;
			}
			ChangeState(pictureBoxStartscreenOn, pictureBoxStartscreenOff, labelStartscreen, START_SCREEN_LABEL_TEXT + DISABLED_TEXT) ;			
		}
		
		//enable applications start screen
		void PictureBoxStartscreenOffClick(object sender, EventArgs e){
			try {
				SetStartScreen(true) ;
			} catch (Exception exc) {
				ShowError(exc.Message) ;
				return ;
			}
			ChangeState(pictureBoxStartscreenOff, pictureBoxStartscreenOn, labelStartscreen, START_SCREEN_LABEL_TEXT + ENABLED_TEXT) ;			
		}
		
		//disable skydrive context menu
		void PictureBoxSkydriveOnClick(object sender, EventArgs e){
			try{
				SaveSkydriveKeys(SKYDRIVE_REG_FILE_BACKUP) ;
				DelSkydriveKeys() ;
			} catch (Exception exc) {
				ShowError(exc.Message) ;
				return ;
			}
			ChangeState(pictureBoxSkydriveOn, pictureBoxSkydriveOff, labelSkydrive, SKYDRIVE_LABEL_TEXT + DISABLED_TEXT) ;
		}
		
		//enable skydrive context menu
		void PictureBoxSkydriveOffClick(object sender, EventArgs e){
			try{
				if(!File.Exists(SKYDRIVE_REG_FILE_BACKUP)){
					throw new Exception("Backup of Skydrive settings not found!") ;
				}
				RestoreSkydriveKeys(SKYDRIVE_REG_FILE_BACKUP) ;
			} catch (Exception exc) {
				ShowError(exc.Message) ;
				return ;
			}
			ChangeState(pictureBoxSkydriveOff, pictureBoxSkydriveOn, labelSkydrive, SKYDRIVE_LABEL_TEXT + ENABLED_TEXT) ;
		}
		
		//disable outlook custom attachments folder
		void PictureBoxOutlookFolderOnClick(object sender, EventArgs e){
			try{
				DelAttachmentSaveLocation() ;
			} catch (Exception exc) {
				ShowError(exc.Message) ;
				return ; 
			}
			ChangeState(pictureBoxOutlookFolderOn, pictureBoxOutlookFolderOff, labelOutlookFolder, OUTLOOK_LABEL_TEXT + DISABLED_TEXT) ;
		}
		
		//enable outlook custom attachments folder
		void PictureBoxOutlookFolderOffClick(object sender, EventArgs e){
			if(!Directory.Exists(textBoxOutlookFolder.Text)){
				folderBrowserDialogAttachment.ShowDialog() ;
				if(folderBrowserDialogAttachment.SelectedPath.Length != 0)
					textBoxOutlookFolder.Text = folderBrowserDialogAttachment.SelectedPath ;
				else
					return ;
			}
			try{
				SetAttachmentSaveLocation(textBoxOutlookFolder.Text) ;
			} catch (Exception exc) {
				ShowError(exc.Message) ;
				return ;
			}
			ChangeState(pictureBoxOutlookFolderOff, pictureBoxOutlookFolderOn, labelOutlookFolder, OUTLOOK_LABEL_TEXT + ENABLED_TEXT) ;		}
	}
}