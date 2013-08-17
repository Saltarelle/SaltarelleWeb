using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("XMLStylesheetProcessingInstruction")]
	public partial class XmlStylesheetProcessingInstruction : XmlProcessingInstruction {
		internal XmlStylesheetProcessingInstruction() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlStylesheetProcessingInstruction> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlStylesheetProcessingInstruction> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlStylesheetProcessingInstruction> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlStylesheetProcessingInstruction> listener, bool capture) {
		}

		[IntrinsicProperty]
		public StyleSheet Sheet {
			get {
				return default(StyleSheet);
			}
		}
	}
}
