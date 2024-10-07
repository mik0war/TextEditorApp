using EditorApp.data;

namespace EditorApp
{
    public class TextEditor
    {

        private TextFile file;
        private BackStack backStack;

        public TextEditor(TextFile file)
        {
            this.file = file;
            this.backStack = new BackStack();
        }

        public void SaveFile(FileManager fileManager)
        {
            fileManager.Save(file);
        }

        public void Undo()
        {
            file.RollbackChange(backStack.Undo());
        }

        public void Redo()
        {
            file.CommitChange(backStack.Redo());
        }

        public void CommitChange(FileChange change)
        {
            file.CommitChange(change);
        }

    }
}
