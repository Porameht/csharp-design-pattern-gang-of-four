using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace command_pattern.UndoCommand
{
    public interface UndoableCommand : Command
    {
        void UnExecute();
    }
    // Resize 1080p => 720p 
    // momento : Keep picture 1080p, 720p
    // command : Keep resolution before, after
}