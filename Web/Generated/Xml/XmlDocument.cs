using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("XMLDocument")]
	public partial class XmlDocument : DocumentBase {
		internal XmlDocument() {
		}

		[IntrinsicProperty]
		public bool Async {
			get { return false; }
			set { }
		}

		public bool Load(string url) {
			return false;
		}
	}
}
