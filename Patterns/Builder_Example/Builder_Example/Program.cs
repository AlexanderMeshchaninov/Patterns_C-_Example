using System;
using Builder_Example.Example1;
using Builder_Example.Example1.Realization;
using Builder_Example.Example2.Realization;

namespace Builder_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var director = new Director();
                director.SetBuilder(new LiteIndustrialUnit());

                var industrialUnit = director.BuildIndustrialUnit();

                Console.WriteLine(industrialUnit);
            }

            {
                var report = new Report.Builder()
                    .GetTitle("My super title")
                    .GetHeader("Header")
                    .GetContent("Some super content")
                    .GetTable("Table one")
                    .GetPageNumber(3)
                    .Build();
                
                Console.WriteLine(report);
            }
        }
    }
}