using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("ProcessingInstruction")]
	public partial class XmlProcessingInstruction : XmlCharacterData {
		internal XmlProcessingInstruction() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlProcessingInstruction> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlProcessingInstruction> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlProcessingInstruction> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlProcessingInstruction> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Target {
			get {
				return null;
			}
		}
	}
}
