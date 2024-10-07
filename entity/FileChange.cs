using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorApp
{

    public abstract class FileChange
    {
        private int position;
        private int length;

        public FileChange(int position, int length)
        {
            this.position = position;
            this.length = length;
        }
        public abstract void Commit(Stack<FileChange> stack);
    }

    public class TextChange : FileChange
    {

        private readonly String text;

        public TextChange(string text, int position, int length) : base(position, length)
        {

            this.text = text;
        }

        public override void Commit(Stack<FileChange> stack)
        {
            stack.Push(this);
        }

    }

    public class ColorChange : FileChange
    {

        private readonly Color color;

        public ColorChange(Color color, int position, int length) : base(position, length)
        {
            this.color = color;
        }

        public override void Commit(Stack<FileChange> stack)
        {
            stack.Push(this);
        }
    }

    public class FontChange : FileChange
    {

        private readonly Font font;

        public FontChange(Font font, int position, int length) : base(position, length)
        {
            this.font = font;
        }

        public override void Commit(Stack<FileChange> stack)
        {
            stack.Push(this);
        }
    }

    public class EmptyChange : FileChange
    {

        public EmptyChange() : base(0, 0)
        {

        }

        public override void Commit(Stack<FileChange> stack)
        {
            throw new NotImplementedException();
        }
    }
}

