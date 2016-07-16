namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("ProcessingInstruction")]
	public partial class XmlProcessingInstruction : XmlCharacterData
	{
		internal extern XmlProcessingInstruction();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlProcessingInstruction> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlProcessingInstruction> listener, bool capture);

		public extern void AddEventListener(XmlProcessingInstructionEvents type, Action listener);

		public extern void AddEventListener(XmlProcessingInstructionEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlProcessingInstructionEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlProcessingInstructionEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlProcessingInstructionEvents type, HtmlEventHandlerWithTarget<XmlProcessingInstruction> listener);

		public extern void AddEventListener(XmlProcessingInstructionEvents type, HtmlEventHandlerWithTarget<XmlProcessingInstruction> listener, bool capture);

		public extern void AddEventListener(XmlProcessingInstructionEvents type, IEventListener listener);

		public extern void AddEventListener(XmlProcessingInstructionEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlProcessingInstruction> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlProcessingInstruction> listener, bool capture);

		public extern void RemoveEventListener(XmlProcessingInstructionEvents type, Action listener);

		public extern void RemoveEventListener(XmlProcessingInstructionEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlProcessingInstructionEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlProcessingInstructionEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlProcessingInstructionEvents type, HtmlEventHandlerWithTarget<XmlProcessingInstruction> listener);

		public extern void RemoveEventListener(XmlProcessingInstructionEvents type, HtmlEventHandlerWithTarget<XmlProcessingInstruction> listener, bool capture);

		public extern void RemoveEventListener(XmlProcessingInstructionEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlProcessingInstructionEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern string Target
		{
			get;
		}
	}
}
