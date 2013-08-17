using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Text")]
	public partial class XmlText : XmlCharacterData {
		public XmlText() {
		}

		public XmlText(string data) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlText> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlText> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlText> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlText> listener, bool capture) {
		}

		public XmlText SplitText(uint offset) {
			return default(XmlText);
		}

		[IntrinsicProperty]
		public string WholeText {
			get {
				return null;
			}
		}
	}
}
