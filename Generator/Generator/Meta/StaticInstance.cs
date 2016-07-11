using System.Collections.Generic;
using Generator.ExtensionMethods;

namespace Generator.Meta
{
    public class StaticInstance
    {
        public string ClassName { get; private set; }
        public string ClassNamespace { get; private set; }
        public string InstanceName { get; private set; }
        public string TypeName { get; private set; }
        public bool GlobalMethods { get; private set; }
        public IReadOnlyList<string> Removes { get; private set; }

        public StaticInstance(string className, string classNamespace, string instanceName, string typeName, bool globalMethods, IEnumerable<string> removes)
        {
            ClassName = className;
            ClassNamespace = classNamespace;
            InstanceName = instanceName;
            TypeName = typeName;
            GlobalMethods = globalMethods;
            Removes = removes.AsReadOnlySafe();
        }
    }
}