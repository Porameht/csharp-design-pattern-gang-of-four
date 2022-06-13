namespace csharp_design_pattern_gang_of_four
{
    class Program
    {
        static void Main(string[] args)
        {
            var stateManager = new CareTaker<Editor>();
            var editor = new Editor("T1","Text 1", 14, "TH SarabunPSK");
            Console.WriteLine(editor);
            var state1 = editor.CreateState();
            stateManager.PushMemento(state1);
            editor = new Editor("T2","Text 2", 16, "AngsanaNew");
            stateManager.PushMemento(editor.CreateState());
            Console.WriteLine(editor);
            editor = new Editor("T3","Text 4", 25, "AngsanaNew");
            Console.WriteLine(editor);
            var undoState = stateManager.Undo();
            editor.RestoreState(undoState);
            Console.WriteLine(editor);
            editor.RestoreState(stateManager.Undo());
            Console.WriteLine(editor);
            editor.RestoreState(stateManager.Redo());
            Console.WriteLine(editor);
            editor = new Editor("T3","Text 4", 25, "AngsanaNew");
            Console.WriteLine(editor);
            stateManager.PushMemento(editor.CreateState());
            editor = new Editor("T4","Text 4", 17, "AngsanaNew");
            Console.WriteLine(editor);
            editor.RestoreState(stateManager.Undo());
            Console.WriteLine(editor);
            


        }
    }
}
