using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace template_method_pattern
{
    public class TransferMoneyTask : TemplateMethod
    {
        public TransferMoneyTask() : base()
        {

        }

        // public TransferMoneyTask(AuditTrail auditTrail)
        // : base(auditTrail)
        // {

        // }

        protected override void DoExecute()
        {
            Console.WriteLine("Transfer money");
            
        }
    }
}