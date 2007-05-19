using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Partymusik.NET {
    public partial class ChangePassword : Form {
        public ChangePassword() {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            this.ok();
        }

        private void ok() {
            if (this.textBoxPassword1.Text.Equals(this.textBoxPassword2.Text)) {
                Partymusik.NET.Properties.Settings.Default.Password = this.textBoxPassword1.Text;
                Partymusik.NET.Properties.Settings.Default.Save();
                //Partymusik.NET.Properties.Settings.Default.Upgrade();
                MessageBox.Show("Password Changed");
                this.Close();
            } else {
                MessageBox.Show("2 Password doesn't match");
                this.textBoxPassword1.Text = "";
                this.textBoxPassword2.Text = "";
            }
        }

        private void ChangePassword_Shown(object sender, EventArgs e) {
            this.textBoxPassword1.Focus();
        }

        private void textBoxPassword2_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.ok();
            }
        }
    }
}