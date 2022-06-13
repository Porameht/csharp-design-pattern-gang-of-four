using System;

namespace state_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // var newCanvas = new Canvas();
            // newCanvas.CurrentToolType = new BucketTool();
            // newCanvas.mouseDown();
            // newCanvas.mouseUp();

            
            var sw = new StopWatch();
            sw.Click();
            sw.Click();
            sw.Click();
        }
    }
}