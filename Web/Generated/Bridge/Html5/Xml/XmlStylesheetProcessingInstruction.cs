using Bridge.Html5.CSS;
using Bridge.Html5.Nodes;

namespace Bridge.Html5.Xml
{
	[Namespace(false), External, Name("XMLStylesheetProcessingInstruction")]
	public partial class XmlStylesheetProcessingInstruction : ProcessingInstruction
	{
		internal extern XmlStylesheetProcessingInstruction();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlStylesheetProcessingInstruction> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlStylesheetProcessingInstruction> listener, bool capture);

		public extern void AddEventListener(XmlStylesheetProcessingInstructionEvents type, Action listener);

		public extern void AddEventListener(XmlStylesheetProcessingInstructionEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlStylesheetProcessingInstructionEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlStylesheetProcessingInstructionEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlStylesheetProcessingInstructionEvents type, HtmlEventHandlerWithTarget<XmlStylesheetProcessingInstruction> listener);

		public extern void AddEventListener(XmlStylesheetProcessingInstructionEvents type, HtmlEventHandlerWithTarget<XmlStylesheetProcessingInstruction> listener, bool capture);

		public extern void AddEventListener(XmlStylesheetProcessingInstructionEvents type, IEventListener listener);

		public extern void AddEventListener(XmlStylesheetProcessingInstructionEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlStylesheetProcessingInstruction> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlStylesheetProcessingInstruction> listener, bool capture);

		public extern void RemoveEventListener(XmlStylesheetProcessingInstructionEvents type, Action listener);

		public extern void RemoveEventListener(XmlStylesheetProcessingInstructionEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlStylesheetProcessingInstructionEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlStylesheetProcessingInstructionEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlStylesheetProcessingInstructionEvents type, HtmlEventHandlerWithTarget<XmlStylesheetProcessingInstruction> listener);

		public extern void RemoveEventListener(XmlStylesheetProcessingInstructionEvents type, HtmlEventHandlerWithTarget<XmlStylesheetProcessingInstruction> listener, bool capture);

		public extern void RemoveEventListener(XmlStylesheetProcessingInstructionEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlStylesheetProcessingInstructionEvents type, IEventListener listener, bool capture);

		public readonly StyleSheet Sheet;
	}
}
