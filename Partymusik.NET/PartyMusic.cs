using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Gassner.Partymusik.NET {
    public partial class PartyMusic : Form {
        private List<string> list;
        private List<MusikFile> resultList;
        private bool searching = false;
        private Object locker;

        public PartyMusic() {
            InitializeComponent();
            listBoxResult.Size = new Size(600, this.Height - listBoxResult.Location.Y - 30);

            this.label1.Visible = false;
            this.progressBar.Visible = false;

            progressBar.Style = ProgressBarStyle.Continuous;

            if (Partymusik.NET.Properties.Settings.Default.Paths != null) {
                this.roots = new string[Partymusik.NET.Properties.Settings.Default.Paths.Count];
                int i = 0;
                foreach (string path in Partymusik.NET.Properties.Settings.Default.Paths) {
                    roots[i] = path;
                    i++;
                }
            } else {
                this.roots = new string[0];
            }
            locker = new Object();
        }

        private void buttonTopMost_Click(object sender, EventArgs e) {
            this.TopMost = !this.TopMost;
        }

        private string[] roots;

        delegate void callback();

        private void progbar() {
            progressBar.PerformStep();
            if (progressBar.Value >= 100)
                progressBar.Value = 1;
        }

        private void endSearch() {
            this.label1.Visible = false;
            this.progressBar.Visible = false;
            foreach(MusikFile muFi in resultList){
                this.listBoxResult.Items.Add(muFi);
            }
            this.textBoxFilesInBuffer.Text = list.Count.ToString();
            this.textBoxHits.Text = resultList.Count.ToString();
            this.textBoxQuery.Enabled = true;
            this.buttonSearch.Enabled = true;
        }

        private void kit() {
            callback progbarDelegate = new callback(progbar);
            bool localsearching;
            lock (locker) {
                localsearching = searching;
            }
            while (localsearching) {
                this.Invoke(progbarDelegate);
                Thread.Sleep(50);
                lock (locker) {
                    localsearching = searching;
                }
            }
            callback endSearchDelegate = new callback(endSearch);
            this.Invoke(endSearchDelegate);
        }

        private void searchFS() {
            list = new List<string>();
            Queue<string> queue = new Queue<string>();
            foreach (string root in roots) {
                queue.Enqueue(root);
            }
            while (queue.Count > 0) {
                string currentDir = queue.Dequeue();
                try {
                    string[] files = Directory.GetFiles(currentDir);
                    string[] dirs = Directory.GetDirectories(currentDir);
                
                    foreach(string dir in dirs){
                        queue.Enqueue(dir);
                    }

                    foreach (string file in files) {
                        list.Add(file.ToLower());
                    }

                } catch (UnauthorizedAccessException) { };
            }
            searchMEM();
        }

        private void searchMEM(){
            string query = textBoxQuery.Text.ToLower();
            string[] patterns = query.Split(' ');
            this.resultList = new List<MusikFile>();
            foreach (string str in list) {
                bool found = true;
                foreach (string pattern in patterns) {
                    if (!str.Contains(pattern)) {
                        found = false;
                    }
                }
                if (found) {
                    this.resultList.Add(new MusikFile(str));
                }
            }
            lock (locker) {
                this.searching = false;
            }
        }

        private void doSearch() {
            bool localsearching;
            lock (locker) {
                localsearching = searching;
            }
            if (localsearching) {
                return;
            }

            if (roots.Length <= 0) {
                MessageBox.Show("Warning: No Paths are defined. (Settings -> Add)");
                return;
            }

            this.listBoxResult.Items.Clear();
            if (this.textBoxQuery.Text.Equals("")) {
                MessageBox.Show("Please enter a Search Query!");
                return;
            }

            this.textBoxQuery.Enabled = false;
            this.buttonSearch.Enabled = false;
            lock (locker) {
                this.searching = true;
            }
            this.progressBar.Visible = true;
            Thread th = new Thread(new ThreadStart(kit));
            th.Start();
            
            if (list == null) {
                //First Time Search
                this.label1.Visible = true;
                Thread thread = new Thread(this.searchFS);
                thread.Priority = ThreadPriority.BelowNormal;
                thread.Start();
            } else {
                //Continuing Search
                Thread thread = new Thread(this.searchMEM);
                thread.Priority = ThreadPriority.BelowNormal;
                thread.Start();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            doSearch();
        }

        private void textBoxQuery_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                doSearch();
            }
        }

        private void listBoxResult_MouseDown(object sender, MouseEventArgs e) {
            if (listBoxResult.SelectedItems.Count > 0) {
                string[] str = new string[] { ((MusikFile)listBoxResult.SelectedItem).FullPath };
                listBoxResult.DoDragDrop(new DataObject(DataFormats.FileDrop, str), DragDropEffects.Copy);
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e) {
            listBoxResult.Size = new Size(600, this.Height - listBoxResult.Location.Y - 30);
        }

        private void listBoxResult_DragEnter(object sender, DragEventArgs e) {

        }

        private void callSettings(){
            PartyMusicSettings partyMusicSettings = new PartyMusicSettings();
            partyMusicSettings.ShowDialog();
            if (partyMusicSettings.PathChanged) {
                if (Partymusik.NET.Properties.Settings.Default.Paths != null) {
                    this.roots = new string[Partymusik.NET.Properties.Settings.Default.Paths.Count];
                    int i = 0;
                    foreach (string path in Partymusik.NET.Properties.Settings.Default.Paths) {
                        roots[i] = path;
                        i++;
                    }
                } else {
                    this.roots = new string[0];
                }
                list = null;
                textBoxFilesInBuffer.Text = "0";
                textBoxHits.Text = "0";
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e) {
            if (!isPasswordProtected()) {
                callSettings();
            } else {
                CheckPassword checkPassword = new CheckPassword();
                checkPassword.ShowDialog();
                if (checkPassword.Result == Result.OK) {
                    callSettings();
                }
                if (checkPassword.Result == Result.Wrong) {
                    MessageBox.Show("Password wrong");
                }
            }
        }

        private void PartyMusic_FormClosing(object sender, FormClosingEventArgs e) {
            if (isPasswordProtected()) {
                CheckPassword checkPassword = new CheckPassword();
                checkPassword.ShowDialog();
                if ((checkPassword.Result == Result.Wrong) || (checkPassword.Result == Result.Cancle)) {
                    if (checkPassword.Result == Result.Wrong) {
                        MessageBox.Show("Password wrong");
                    }
                    e.Cancel = true;
                }
            }
        }

        private void PartyMusic_SizeChanged(object sender, EventArgs e) {
            if (Partymusik.NET.Properties.Settings.Default.AlwaysFullsize && (this.WindowState != FormWindowState.Maximized)) {
                this.WindowState = FormWindowState.Maximized;
            }
            listBoxResult.Size = new Size(600, this.Height - listBoxResult.Location.Y - 30);
        }

        private void PartyMusic_Load(object sender, EventArgs e) {
            if (Partymusik.NET.Properties.Settings.Default.AlwaysFullsize) {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private bool isPasswordProtected() {
            return Partymusik.NET.Properties.Settings.Default.PasswordProtection;
        }

        private void buttonStartPlayer_Click(object sender, EventArgs e) {
            if (!isPasswordProtected()) {
                callPlayer();
            } else {
                CheckPassword checkPassword = new CheckPassword();
                checkPassword.ShowDialog();
                if (checkPassword.Result == Result.OK) {
                    callPlayer();
                }
                if (checkPassword.Result == Result.Wrong) {
                    MessageBox.Show("Password wrong");
                }
            }
        }

        private void callPlayer() {
            string playerPath = Partymusik.NET.Properties.Settings.Default.PlayerPath;
            if (File.Exists(playerPath)){
                System.Diagnostics.Process.Start(playerPath);
            }else{
                MessageBox.Show("File does not Exist");
            }
        }
    }
}