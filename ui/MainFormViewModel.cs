using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EditorApp.data;

namespace EditorApp
{
    public class MainForm
    {

        private FileManager fileManager;
        private TextFile file;

        public MainForm(FileManager fileManager)
        {
            this.fileManager = fileManager;
        }

        void GetFile(String path)
        {
            file = fileManager.CreateFile(path);
        }

        void OpenFile(String path)
        {
            file = fileManager.GetFile(path);
        }

        TextEditViewModel OpenTextEditViewModel()
        {
            return new TextEditViewModel(new TextEditorDriver(file), fileManager);
        }

    }

}