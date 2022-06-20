using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace command_pattern.UndoCommand
{
    public class HtmlDocument
    {
        public string Content { get; set;}
        public void MakeBold(){
            Content = $"<b>{Content}</b>";
        }

        public override string ToString()
        {
            return Content;
        }
    }
}