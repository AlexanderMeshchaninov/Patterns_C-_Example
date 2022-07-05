using State_Example.Example2.Abstractions;

namespace State_Example.Example2.Realization
{
    //Контекст класс воды
    public class Water
    {
        public IWaterState State { private get; set; }

        public Water(IWaterState waterState)
        {
            State = waterState;
        }

        public void Heat()
        {
            State.Heat(this);
        }

        public void Frost()
        {
            State.Frost(this);
        }
    }
}