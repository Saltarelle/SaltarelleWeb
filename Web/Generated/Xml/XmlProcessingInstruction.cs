using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("ProcessingInstruction")]
	public partial class XmlProcessingInstruction : XmlCharacterData {
		internal XmlProcessingInstruction() {
		}

		[IntrinsicProperty]
		public string Target {
			get {
				return null;
			}
		}
	}
}
