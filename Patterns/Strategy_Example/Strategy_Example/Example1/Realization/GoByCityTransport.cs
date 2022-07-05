using System.Collections.Generic;
using System.Linq;
using Strategy_Example.Example1.Abstractions;

namespace Strategy_Example.Example1.Realization
{
    public sealed class GoByCityTransport : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var contentDict = data as Dictionary<string, string>;

            var result = contentDict
                .Where(x => x.Key == "GoByCityTransport")
                .FirstOrDefault()
                .Value;

            return result;
        }
    }
}