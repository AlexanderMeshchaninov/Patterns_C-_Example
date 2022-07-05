namespace Facade_Example.Example2.Realization
{
    public class VisualStudioFacade
    {
        private TextEditor _textEditor;
        private Compiler _compiler;
        private Clr _clr;

        public VisualStudioFacade(
            TextEditor textEditor, 
            Compiler compiler,
            Clr clr
            )
        {
            _textEditor = textEditor;
            _compiler = compiler;
            _clr = clr;
        }

        public void Start()
        {
            _textEditor.CreateCode();
            _textEditor.Save();
            _compiler.Compile();
            _clr.Execute();
        }

        public void Stop()
        {
            _clr.Finish();
        }
    }
}