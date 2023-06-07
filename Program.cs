// See https://aka.ms/new-console-template for more information
using Microsoft.CodeAnalysis;
using StrideSourceGened;
using YamlDotNet.Core.Events;
using YamlDotNet.Core;
using YamlDotNet.RepresentationModel;
using System.Diagnostics;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<Benchmark>();
