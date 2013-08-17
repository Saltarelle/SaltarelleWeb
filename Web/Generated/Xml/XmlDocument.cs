using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("XMLDocument")]
	public partial class XmlDocument : DocumentBase {
		internal XmlDocument() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlDocument> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlDocument> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Async {
			get {
				return false;
			}
			set {
			}
		}

		public bool Load(string url) {
			return false;
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlDocument> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlDocument> listener, bool capture) {
		}
	}
}
