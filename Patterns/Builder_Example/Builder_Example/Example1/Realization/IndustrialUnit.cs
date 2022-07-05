using System.Threading;
using Builder_Example.Example1.Abstractions;

namespace Builder_Example.Example1.Realization
{
    public class IndustrialUnit
    {
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public float Temperature
        {
            get => _temperature;
            set => _temperature = value;
        }

        public double Pressure
        {
            get => _pressure;
            set => _pressure = value;
        }

        public int Voltage
        {
            get => _voltage;
            set => _voltage = value;
        }

        public string SupplierName
        {
            get => _supplierName;
            set => _supplierName = value;
        }

        public OperatingStatus OperatingStatus
        {
            get => _operatingStatus;
            set => _operatingStatus = value;
        }

        private string _name;
        private float _temperature;
        private double _pressure;
        private int _voltage;
        private string _supplierName;
        private OperatingStatus _operatingStatus;

        public override string ToString()
        {
            return $"IndustrialUnit:\n" +
                   $" Name: {Name}\n" +
                   $" Temp: {Temperature}\n" +
                   $" Pressure: {Pressure}\n" +
                   $" Volt: {Voltage}\n" +
                   $" SupplName: {SupplierName}\n" +
                   $" OperStatus: {OperatingStatus}\n";
        }
    }
}