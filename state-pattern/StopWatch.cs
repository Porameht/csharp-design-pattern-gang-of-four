using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace state_pattern
{
    public class StopWatch
    {

     private bool _isRunning = false;
     public void Click()
     {
        if (_isRunning)
        {
            _isRunning = false;
            Console.WriteLine($"Stopped");
            
        }
        else {
            _isRunning = true;
            Console.WriteLine($"Running");
            
        }
     }   
    }

}