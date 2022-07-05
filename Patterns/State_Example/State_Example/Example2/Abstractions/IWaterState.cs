using State_Example.Example2.Realization;

namespace State_Example.Example2.Abstractions
{
    public interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}