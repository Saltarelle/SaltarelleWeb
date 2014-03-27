using System.Runtime.CompilerServices;

namespace System.Xml {
	public partial class XmlNode {
		[IntrinsicProperty]
		[ScriptName("textContent")]
		public string InnerText {
			get { return null; }
		}

		public string OuterXml {
			[InlineCode("new XMLSerializer().serializeToString({this})")] get { return null; }
		}

	}
}
