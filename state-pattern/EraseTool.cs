using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace state_pattern
{
    public class EraseTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine($"Eraser icon");
            
        }

        public void mouseUp()
        {
            Console.WriteLine($"Erase something");
            
        }
    }
}