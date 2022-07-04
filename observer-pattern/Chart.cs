using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace observer_pattern
{
    public class Chart : Observer
    {
        public void Update()
        {
            Console.WriteLine("Got notify from datasource");
            
        }
        
    }
}