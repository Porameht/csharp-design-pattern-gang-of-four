namespace command_pattern
{
    public class Button
    {
        public string Text { get; set;}
        public Command OnClick { get; set;}
        public void Click()
        {
            OnClick.Execute();
        }
    }
}