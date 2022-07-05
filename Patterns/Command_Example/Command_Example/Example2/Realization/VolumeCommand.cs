using Command_Example.Example2.Abstractions;

namespace Command_Example.Example2.Realization
{
    public class VolumeCommand : IMyCommand
    {
        private Volume _volume;

        public VolumeCommand(Volume volume)
        {
            _volume = volume;
        }

        public void Execute()
        {
            if (_volume is not null)
            {
                _volume.RaiseLevel();
            }
        }

        public void Undo()
        {
            if (_volume is not null)
            {
                _volume.DropLevel();
            }
        }
    }
}