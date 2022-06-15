using System;

namespace interator_pattern_netcore
{
    public class BrowserHistory
    {
        public BrowserHistory(string url, DateTime accessTime)
        {
            this.Url = url;
            this.AccessTime = accessTime;
        }
        public string Url { get; }
        public DateTime AccessTime { get; }

        public override string ToString()
        {
            return $"{Url} Access at {AccessTime}";
        }
    }
}