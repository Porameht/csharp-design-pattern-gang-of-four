using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace command_pattern.UndoCommand
{
    public class History
    {
        private Stack<UndoableCommand> _histories;
        public History(){
            _histories = new Stack<UndoableCommand>();
        }
        public void Push(UndoableCommand command)
        {
            _histories.Push(command);
        }

        public UndoableCommand Pop()
        {
            return _histories.Pop();
        }

        public int Size => _histories.Count;
    }

}