using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("XMLStylesheetProcessingInstruction")]
	public partial class XmlStylesheetProcessingInstruction : XmlProcessingInstruction {
		internal XmlStylesheetProcessingInstruction() {
		}

		[IntrinsicProperty]
		public StyleSheet Sheet {
			get {
				return default(StyleSheet);
			}
		}
	}
}
