using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy_pattern
{
    public class PngCompressor : Compressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing PNG format");
        }
    }
}