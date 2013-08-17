using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Comment")]
	public partial class XmlComment : XmlCharacterData {
		public XmlComment() {
		}

		public XmlComment(string data) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlComment> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlComment> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlComment> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlComment> listener, bool capture) {
		}
	}
}
