using Builder_Example.Example1.Abstractions;

namespace Builder_Example.Example1.Realization
{
    public sealed class HeavyIndustrialUnit : IndustrialBuilderBase
    {
        public override void BuildName()
        {
            IndustrialUnit.Name = "Heavy Industry";
        }

        public override void BuildTemperature()
        {
            IndustrialUnit.Temperature = 350.0f;
        }

        public override void BuildPressure()
        {
            IndustrialUnit.Pressure = 200.0;
        }

        public override void BuildVoltage()
        {
            IndustrialUnit.Voltage = 380;
        }

        public override void BuildSupplierName()
        {
            IndustrialUnit.SupplierName = "Second supplier";
        }

        public override void BuildOperatingStatus()
        {
            IndustrialUnit.OperatingStatus = OperatingStatus.OPERATING;
        }
    }
}