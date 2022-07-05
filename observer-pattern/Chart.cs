using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace observer_pattern
{
    public class Chart : Observer<int>
    {
        public void Update()
        {
            Console.WriteLine("Got notify from datasource");
            
        }

        public void Update(int value)
        {
            Console.WriteLine("Got notify from datasource : "+value);
            
        }
        
    }
    public class PullChart : Observer
    {
        private DataSource _dataSource;
        
        public PullChart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        

        
        // public void Update()
        // {
        //     Console.WriteLine("Got notify from datasource");
            
        // }

        public void Update()
        {
            Console.WriteLine("Got notify from datasource : " + _dataSource.Data);
            
        }
        
    }
}