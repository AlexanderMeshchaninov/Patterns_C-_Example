namespace Facade_Example.Example1.Realization
{
    public class Facade
    {
        private SubsystemA _subsystemA;
        private SubsystemB _subsystemB;

        public Facade(SubsystemA subsystemA, SubsystemB subsystemB)
        {
            _subsystemA = subsystemA;
            _subsystemB = subsystemB;
        }

        public string Operation()
        {
            string result = "Facade initialize subsystems\n";
            result += "Facade initialize subsystemA\n";
            result += _subsystemA.OperationA();
            result += _subsystemA.OperationN();
            result += "Facade initialize subsystemB\n";
            result += _subsystemB.OperationB();
            result += _subsystemB.OperationZ();

            return result;
        }
    }
}