using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gassner.Partymusik.NET {
    public partial class PartyMusicSettings : Form {

        private bool pathChanged;

        public bool PathChanged {
            get { return pathChanged; }
        }

        public PartyMusicSettings() {
            InitializeComponent();

            System.Collections.Specialized.StringCollection sc = Partymusik.NET.Properties.Settings.Default.Paths;
            string password = Partymusik.NET.Properties.Settings.Default.Password;
            pathChanged = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void updatePaths() {
            pathChanged = true;
            if (Partymusik.NET.Properties.Settings.Default.Paths == null) {
                Partymusik.NET.Properties.Settings.Default.Paths = new System.Collections.Specialized.StringCollection();
            } else {
                Partymusik.NET.Properties.Settings.Default.Paths.Clear();
            }
            foreach (string path in listBoxDirectories.Items) {
                Partymusik.NET.Properties.Settings.Default.Paths.Add(path);
            }
            Partymusik.NET.Properties.Settings.Default.Save();
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }

        private void buttonAddDirectory_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK) {
                listBoxDirectories.Items.Add(fbd.SelectedPath);
                updatePaths();
            }
        }

        private void buttonDelDirectory_Click(object sender, EventArgs e) {
            if (listBoxDirectories.SelectedItems.Count == 1){
                listBoxDirectories.Items.Remove(listBoxDirectories.SelectedItem);
                updatePaths();
            }else{
                MessageBox.Show("Please select 1 Item");
            }
        }

        private void PartyMusicSettings_Shown(object sender, EventArgs e) {
            if (Partymusik.NET.Properties.Settings.Default.Paths != null) {
                foreach (string path in Partymusik.NET.Properties.Settings.Default.Paths) {
                    listBoxDirectories.Items.Add(path);
                }
            }
            this.checkBoxAlwaysFullsize.Checked = Partymusik.NET.Properties.Settings.Default.AlwaysFullsize;
            this.checkBoxPasswordProtection.Checked = Partymusik.NET.Properties.Settings.Default.PasswordProtection;
            if (Partymusik.NET.Properties.Settings.Default.PlayerPath.Equals("")) {
                labelPlayerPath.Text = "No Player defined";
            } else {
                labelPlayerPath.Text = Partymusik.NET.Properties.Settings.Default.PlayerPath;
            }
        }

        private void checkBoxAlwaysFullsize_CheckedChanged(object sender, EventArgs e) {
            Partymusik.NET.Properties.Settings.Default.AlwaysFullsize = this.checkBoxAlwaysFullsize.Checked;
            Partymusik.NET.Properties.Settings.Default.Save();
        }

        private void checkBoxPasswordProtection_CheckedChanged(object sender, EventArgs e) {
            Partymusik.NET.Properties.Settings.Default.PasswordProtection = this.checkBoxPasswordProtection.Checked;
            Partymusik.NET.Properties.Settings.Default.Save();
        }

        private void buttonFindPlayer_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) {
                Partymusik.NET.Properties.Settings.Default.PlayerPath = ofd.FileName;
                Partymusik.NET.Properties.Settings.Default.Save();
                labelPlayerPath.Text = ofd.FileName;
            }
        }


    }
}