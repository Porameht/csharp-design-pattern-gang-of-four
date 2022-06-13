using System;

namespace state_pattern
{
    public class Canvas
    {
        public Tool CurrentToolType {get; set;}
        public void mouseDown()
        {
            CurrentToolType.mouseDown();
        }

        public void mouseUp()
        {
            CurrentToolType.mouseUp();
        }

    
    }
        
}