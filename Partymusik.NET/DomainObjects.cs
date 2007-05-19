using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Partymusik.NET {
    public class MusikFile {
        private string fullPath;
        private string fileName;
        private string invertRestPath;

        public MusikFile(string path) {
            this.fullPath = path;
            this.fileName = new FileInfo(path).Name;
            string[] pathElements = new FileInfo(path).DirectoryName.Split(Path.DirectorySeparatorChar);
            StringBuilder sb = new StringBuilder();
            foreach(string str in pathElements){
                sb.Insert(0, Path.DirectorySeparatorChar);
                sb.Insert(0, str);
            }
            this.invertRestPath = sb.ToString();
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
            return fileName + "   " + this.invertRestPath;
        }
    }
}
