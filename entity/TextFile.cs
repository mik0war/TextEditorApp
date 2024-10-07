using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorApp
{
    public class TextFile
    {

        private String path;
        private FileStream fileStream;

        public TextFile(String path, FileStream fileStream)
        {
            this.path = path;
            this.fileStream = fileStream;
        }

        public void Save()
        {
            fileStream.Close();
        }

        public void CommitChange(FileChange change)
        {

        }

        public void RollbackChange(FileChange change)
        {

        }
    }
}

