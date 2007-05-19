using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Partymusik.NET {
    public enum Result { OK, Wrong, Cancle };

    public partial class CheckPassword : Form {
        public CheckPassword() {
            InitializeComponent();
        }

        private Result result;

        public Result Result {
            get { return this.result; }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.result = Result.Cancle;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            this.checkPassword();
        }

        private void checkPassword() {
            if (Partymusik.NET.Properties.Settings.Default.Password.Equals(this.textBoxPassword.Text)) {
                this.result = Result.OK;
            } else {
                this.result = Result.Wrong;
            }
            this.Close();
        }

        private void CheckPassword_Shown(object sender, EventArgs e) {
            textBoxPassword.Focus();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                checkPassword();
            }
        }
    }
}