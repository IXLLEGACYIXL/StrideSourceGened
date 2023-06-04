// See https://aka.ms/new-console-template for more information
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Stride.Core.Extensions;
using Stride.Core.Shaders.Ast.Hlsl;
using StrideSourceGened;
using System.Collections.Generic;
using System.Reflection;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

Console.WriteLine("Hello, World!");
TestClass class1 = new TestClass();
TestClass class2 = new TestClass()
    {
    Number = 1,
    FancyClass = new TestClass()
      
        {
        Number = 2,
            FancyClass = new TestClass()
            {
                Number = 3,
                Test = "Hello recursive"
            }
        }

    };
var serializer = new SerializerBuilder().Build();

string yaml = serializer.Serialize(GeneratedSerializerTestClass.WriteToDictionary(class2));

File.WriteAllText("C:\\Godot\\testClass.yaml", yaml);

