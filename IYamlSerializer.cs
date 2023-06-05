using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.RepresentationModel;

namespace StrideSourceGened;
public interface IYamlSerializer<T>
{
    Type SerializedType { get; }
    YamlMappingNode ConvertToYaml(T obj);
   // void WriteToStream(Stream stream,T obj);
   // void WriteToFile(string path, T obj);
}
