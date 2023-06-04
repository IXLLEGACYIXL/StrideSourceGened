// See https://aka.ms/new-console-template for more information
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Stride.Core.Extensions;
using Stride.Core.Shaders.Ast.Hlsl;
using StrideSourceGened;
using System.Reflection;

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
var x = GeneratedSerializerTestClass.WriteToDictionary(class1);
var y = GeneratedSerializerTestClass.WriteToDictionary(class2);
Console.WriteLine(x);
