using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorApp
{
    public class BackStack
    {
        private Stack<FileChange> stack;
        private Queue<FileChange> redoQueue;
        private int stackSize;

        public BackStack() {
            stack = new Stack<FileChange>();
            redoQueue = new Queue<FileChange>();
            stackSize = 0;
        }

        public void Commit(FileChange change) {
            change.Commit(stack);
            redoQueue.Clear();
        }

        public FileChange Undo()
        {
            redoQueue.Enqueue(stack.Peek());

            return stack.Pop();
        }

        public FileChange Redo()
        {
            if (redoQueue.Count == 0)
                return new EmptyChange();


            return redoQueue.Dequeue();
        }

    }
}
