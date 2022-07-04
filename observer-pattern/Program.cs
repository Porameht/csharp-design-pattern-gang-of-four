using System;

namespace observer_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource1 = new DataSource();
            var sheet1 = new SpreadSheet();
            var sheet2 = new SpreadSheet();
            var chart1 = new Chart();

            dataSource1.AddObserver(sheet1);
            dataSource1.AddObserver(sheet2);
            dataSource1.AddObserver(chart1);

            dataSource1.Data = 20;
        }
    }
}