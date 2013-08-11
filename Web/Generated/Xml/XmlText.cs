using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Text")]
	public partial class XmlText : XmlCharacterData {
		public XmlText() {
		}

		public XmlText(string data) {
		}

		public XmlText SplitText(uint offset) {
			return default(XmlText);
		}

		[IntrinsicProperty]
		public string WholeText {
			get { return null; }
		}
	}
}
