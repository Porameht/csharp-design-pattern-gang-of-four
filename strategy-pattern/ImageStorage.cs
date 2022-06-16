namespace strategy_pattern
{
    public abstract class ImageStorage
    {
        protected readonly Compressor _compressor;
        protected readonly Filter _filter;
        public ImageStorage(Compressor compressor, Filter filter)
        {
            _compressor = compressor;
            _filter = filter;
        }
        public abstract void Store(string fileName);

    }
}