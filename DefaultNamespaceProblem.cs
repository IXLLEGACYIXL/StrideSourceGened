using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// adding here datacontract attribute will result in an error that global namespace is not allowed
/// </summary>
public class DefaultNamespaceProblem
{
    [DataMember]
    public int Test { get; set; }
}
