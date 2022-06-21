using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace template_method_pattern
{
    public class AuditTrail
    {
         public void Record()
        {
            Console.WriteLine("Start logging transaction");
        }

        public void Stop()
        {
            Console.WriteLine("Stop logging transaction");
        }
    }
}