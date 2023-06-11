using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace StrideSourceGened
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        [Params(1,100,1000,10000)]
        public int count;

        TestClass x = new TestClass()
        {
            FancyClass = new TestClass()
            {
                Test = "Hello recursive"
            },
        };

  

    }

}


