using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Gassner.Partymusik.NET {
    public class MusikFile {
        private string fullPath;
        private string fileName;
        private string invertRestPath;
        private long filesize;
        private string filesizeText;

        /// <summary>
        /// Constructor inits the Members
        /// Exception: PathTooLongException
        /// </summary>
        /// <param name="path">the path of the File</param>
        public MusikFile(string path) {
            this.fullPath = path;
            FileInfo fileInfo = new FileInfo(path);
            this.fileName = fileInfo.Name;
            this.filesize = fileInfo.Length;

            if (this.filesize < 1024) {
                this.filesizeText = String.Format("{0:0.##}", this.filesize) + " B";
            } else if (this.filesize < (1024 * 1024)) {
                this.filesizeText = String.Format("{0:0.##}", ((double)this.filesize) / 1024.0) + " KB";
            } else if (this.filesize < (1024 * 1024 * 1024)) {
                this.filesizeText = String.Format("{0:0.##}", ((double)this.filesize) / (1024.0 * 1024.0)) + " MB";
            } else {
                this.filesizeText = String.Format("{0:0.##}", ((double)this.filesize) / (1024.0 * 1024.0 * 1024.0)) + " GB";
            }

            string[] pathElements = new FileInfo(path).DirectoryName.Split(Path.DirectorySeparatorChar);
            StringBuilder sb = new StringBuilder();
            foreach(string str in pathElements){
                sb.Insert(0, Path.DirectorySeparatorChar);
                sb.Insert(0, str);
            }
            this.invertRestPath = sb.ToString();
        }

        public string FileSizeText {
            get {
                return filesizeText;
            }
        }

        public long FileSize {
            get {
                return filesize;
            }
        }

        public string FullPath {
            get {
                return fullPath;
            }
        }

        public string FileName {
            get {
                return fileName;
            }
        }

        public override string ToString() {
            return fileName + "   " + FileSizeText + " " + this.invertRestPath;
        }
    }
}
