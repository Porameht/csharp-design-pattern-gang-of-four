using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy_pattern
{
    public interface Compressor
    {
        // byte[] Compress(byte[] image);
        void Compress(string fileName);
    }
}