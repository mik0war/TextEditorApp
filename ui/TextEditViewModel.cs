using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EditorApp.data;


namespace EditorApp
{
    public class TextEditViewModel
    {
        private readonly TextEditorDriver textEditor;
        private readonly FileManager fileManager;

        public TextEditViewModel(TextEditorDriver textEditor, FileManager fileManager)
        {
            this.textEditor = textEditor;
            this.fileManager = fileManager;
        }

        public void SaveChanges()
        {
            textEditor.SaveFile(fileManager);
        }

        public void Commit(FileChange change)
        {

        }

    }
}
