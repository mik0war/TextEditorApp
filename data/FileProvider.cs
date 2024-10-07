using EditorApp.domain;

namespace EditorApp
{
    public interface IFileProvider
    {

        TextFile OpenFile(string path);

        void SaveFile(TextFile file);

        void DeleteFile(string path);


        public class Base : IFileProvider
        {
            private readonly PathFormatter _formatter;

            public Base(PathFormatter formatter)
            {
                this._formatter = formatter;
            }

            TextFile IFileProvider.OpenFile(string path)
            {
                if (File.Exists(path))
                {
                    path = _formatter.Format(path);
                }

                FileStream stream = File.Create(path);

                return new TextFile(path, stream);
            }

            void IFileProvider.SaveFile(TextFile file)
            {
                file.Save();
            }

            public void DeleteFile(string path)
            {
                File.Delete(path);
            }


        }
    }
}

