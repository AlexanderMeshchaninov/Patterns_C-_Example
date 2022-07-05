using Builder_Example.Example1.Abstractions;
using Builder_Example.Example1.Realization;

namespace Builder_Example.Example1
{
    //Директор строительства
    public sealed class Director
    {
        private IndustrialBuilderBase _builderBase;

        public void SetBuilder(IndustrialBuilderBase builder)
        {
            _builderBase = builder;
        }

        public IndustrialUnit BuildIndustrialUnit()
        {
            _builderBase.CreateIndustrial();
            
            _builderBase.BuildName();
            _builderBase.BuildTemperature();
            _builderBase.BuildPressure();
            _builderBase.BuildVoltage();
            _builderBase.BuildSupplierName();
            _builderBase.BuildOperatingStatus();

            IndustrialUnit industrialUnit = _builderBase.GetIndustrialUnit();

            return industrialUnit;
        }
    }
}