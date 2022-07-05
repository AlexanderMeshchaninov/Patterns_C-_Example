using Builder_Example.Example1.Realization;

namespace Builder_Example.Example1.Abstractions
{
    //Либо делаем интерфейс...
    public abstract class IndustrialBuilderBase
    {
        public IndustrialUnit IndustrialUnit;

        public void CreateIndustrial()
        {
            IndustrialUnit = new IndustrialUnit();
        }

        public abstract void BuildName();
        public abstract void BuildTemperature();
        public abstract void BuildPressure();
        public abstract void BuildVoltage();
        public abstract void BuildSupplierName();
        public abstract void BuildOperatingStatus();

        public IndustrialUnit GetIndustrialUnit()
        {
            return IndustrialUnit;
        }
    }
}