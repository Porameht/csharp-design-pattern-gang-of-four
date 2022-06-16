using System;

namespace strategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var imgStorage = new CloudImageStorage(new JpegCompressor(), new BlackWhiteFilter());
            imgStorage.Store("abc");
        }
    }
}