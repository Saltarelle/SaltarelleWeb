using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.ExtensionMethods;

namespace Generator.Meta {
	public class Metadata {
		public Dictionary<string, TypeMetadata> Types { get; private set; }
		public IReadOnlyList<StaticInstance> StaticInstances { get; private set; }

		public Metadata(IEnumerable<TypeMetadata> types, IEnumerable<StaticInstance> staticInstances) {
			Types = types.ToDictionary(t => t.TypeName);
			StaticInstances = staticInstances.AsReadOnlySafe();
		}
	}
}
