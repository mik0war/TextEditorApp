using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorApp.data
{
    public class FileManager
    {
        private IFileProvider fileProvider;

        public FileManager(IFileProvider fileProvider)
        {
            this.fileProvider = fileProvider;
        }

        public void Save(TextFile file)
        {
            fileProvider.SaveFile(file);
        }

        public TextFile GetFile(string path)
        {
            return fileProvider.OpenFile(path);
        }

        public void Delete(string path)
        {
            fileProvider.DeleteFile(path);
        }

        public TextFile CreateFile(string path)
        {
            return fileProvider.OpenFile(path);
        }

    }
}
