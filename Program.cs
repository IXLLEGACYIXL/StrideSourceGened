// See https://aka.ms/new-console-template for more information
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Stride.Core.Extensions;
using Stride.Core.Shaders.Ast.Hlsl;
using StrideSourceGened;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

var x = new TestClass()
{
    FancyClass = new TestClass()
    {
        Test = "Hello recursive"
    },
};
YamlStream st = new YamlStream(new YamlDocument(GeneratedSerializerTestClass.ConvertToYaml(x)));
using (TextWriter writer = File.CreateText("C:\\Godot\\some-file.yaml"))
{
    st.Save(writer, false);
}