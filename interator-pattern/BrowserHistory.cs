using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interator_pattern
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