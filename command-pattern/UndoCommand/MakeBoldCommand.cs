using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace command_pattern.UndoCommand
{
    public class MakeBoldCommand : UndoableCommand

    {
        private string _previousContent;
        private readonly HtmlDocument _htmlDocument;

        private readonly History _history;

        public MakeBoldCommand(HtmlDocument htmlDocument, History history){
            _htmlDocument = htmlDocument;
            _history = history;
        }

        public void Execute()
        {
            _previousContent = _htmlDocument.Content;
            _htmlDocument.MakeBold();
            _history.Push(this);
        }

        public void UnExecute()
        {
            _htmlDocument.Content = _previousContent;
        }
    }
}