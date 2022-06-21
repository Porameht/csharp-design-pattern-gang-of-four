namespace template_method_pattern
{
    class Program 
    {
        static void Main(string[] args)
        {
            // transfer money
            var transferTask = new TransferMoneyTask();
            transferTask.Execute();
            // generate report
            var generateReportTask = new GenerateReportTask();
            generateReportTask.Execute();
        }
    }
}