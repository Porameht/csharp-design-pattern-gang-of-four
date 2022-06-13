using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace state_pattern
{
    public class BucketTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine($"Bucket icon");
            
        }

        public void mouseUp()
        {
            Console.WriteLine($"Paint one color");
            
        }
    }
}