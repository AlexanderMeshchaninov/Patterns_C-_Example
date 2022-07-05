using Builder_Example.Example1.Abstractions;

namespace Builder_Example.Example1.Realization
{
    public class LiteIndustrialUnit : IndustrialBuilderBase
    {
        public override void BuildName()
        {
            IndustrialUnit.Name = "Light Industry";
        }

        public override void BuildTemperature()
        {
            IndustrialUnit.Temperature = 100.0f;
        }

        public override void BuildPressure()
        {
            IndustrialUnit.Pressure = 10.0;
        }

        public override void BuildVoltage()
        {
            IndustrialUnit.Voltage = 220;
        }

        public override void BuildSupplierName()
        {
            IndustrialUnit.SupplierName = "First supplier";
        }

        public override void BuildOperatingStatus()
        {
            IndustrialUnit.OperatingStatus = OperatingStatus.OPERATING;
        }
    }
}