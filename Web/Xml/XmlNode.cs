using System.Runtime.CompilerServices;

namespace System.Xml {
	public partial class XmlNode {
		[IntrinsicProperty]
		[ScriptName("textContent")]
		public string InnerText {
			get { return null; }
		}

		[IntrinsicProperty]
		[ScriptName("nodeName")]
		public string Name {
			get { return null; }
		}

		[IntrinsicProperty]
		[ScriptName("nodeValue")]
		public string Value {
			get { return null; }
			set { }
		}

		public string OuterXml {
			[InlineCode("new XMLSerializer().serializeToString({this})")] get { return null; }
		}

	}
}
