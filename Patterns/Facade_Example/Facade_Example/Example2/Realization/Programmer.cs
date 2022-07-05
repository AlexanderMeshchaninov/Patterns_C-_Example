namespace Facade_Example.Example2.Realization
{
    public class Programmer
    {
        public void CreateApplication(VisualStudioFacade visualStudioFacade)
        {
            visualStudioFacade.Start();
            visualStudioFacade.Stop();
        }
    }
}