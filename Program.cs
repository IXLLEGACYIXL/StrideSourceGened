// See https://aka.ms/new-console-template for more information
using Microsoft.CodeAnalysis;
using StrideSourceGened;
using YamlDotNet.Core.Events;
using YamlDotNet.Core;
using YamlDotNet.RepresentationModel;
using System.Diagnostics;
using BenchmarkDotNet.Running;
using System.Runtime.ConstrainedExecution;
using YamlDotNet;

BenchmarkRunner.Run<Benchmark>();

class Test 
{
    public string IdentifierTag { get; }

    public YamlMappingNode ConvertToYaml(Test obj)
    {
        throw new NotImplementedException();
    }

    public YamlMappingNode ConvertToYaml(object obj)
    {
        throw new NotImplementedException();
    }
}