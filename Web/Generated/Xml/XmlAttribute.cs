using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Attr")]
	public partial class XmlAttribute : XmlNode {
		internal XmlAttribute() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlAttribute> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlAttribute> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string LocalName {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string NamespaceURI {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public XmlElement OwnerElement {
			get {
				return default(XmlElement);
			}
		}

		[IntrinsicProperty]
		public string Prefix {
			get {
				return null;
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlAttribute> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlAttribute> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Specified {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public string Value {
			get {
				return null;
			}
			set {
			}
		}
	}
}
