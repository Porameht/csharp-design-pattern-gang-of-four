using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace observer_pattern
{

    public class DataSource : Subject
    {
        private int _data;
    
        public int Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
                NotifyObserver();
                
            }
        }

    }
   
}