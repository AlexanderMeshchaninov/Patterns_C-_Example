using Command_Example.Example2.Abstractions;

namespace Command_Example.Example2.Realization
{
    public class MicrowaveCommand : IMyCommand
    {
        private Microwave _microwave;
        private int _time;

        public MicrowaveCommand(Microwave microwave, int time)
        {
            _microwave = microwave;
            _time = time;
        }

        public void Execute()
        {
            _microwave.StartCooking(_time);
            _microwave.StopCooking();
        }

        public void Undo()
        {
            _microwave.StopCooking();
        }
    }
}