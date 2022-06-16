using System;

namespace strategy_pattern
{
    public class LocalImageStorage : ImageStorage
    {

        // public void Store(byte[] data)

        public LocalImageStorage(Compressor compressor, Filter filter) : base(compressor, filter)
        {

        }
        public override void Store(string fileName)
        {
            _compressor.Compress(fileName);
            _filter.Filter(fileName);

            Console.WriteLine($"Storing image {fileName}");
        }
    }
}