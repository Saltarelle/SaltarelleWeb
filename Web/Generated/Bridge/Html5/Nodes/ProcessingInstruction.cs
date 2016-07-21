namespace Bridge.Html5.Nodes
{
	[Namespace(false), External]
	public partial class ProcessingInstruction : CharacterData
	{
		internal extern ProcessingInstruction();

		public extern void AddEventListener(ProcessingInstructionEvents type, Action listener);

		public extern void AddEventListener(ProcessingInstructionEvents type, Action listener, bool capture);

		public extern void AddEventListener(ProcessingInstructionEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ProcessingInstructionEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ProcessingInstructionEvents type, HtmlEventHandlerWithTarget<ProcessingInstruction> listener);

		public extern void AddEventListener(ProcessingInstructionEvents type, HtmlEventHandlerWithTarget<ProcessingInstruction> listener, bool capture);

		public extern void AddEventListener(ProcessingInstructionEvents type, IEventListener listener);

		public extern void AddEventListener(ProcessingInstructionEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ProcessingInstruction> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ProcessingInstruction> listener, bool capture);

		public extern void RemoveEventListener(ProcessingInstructionEvents type, Action listener);

		public extern void RemoveEventListener(ProcessingInstructionEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ProcessingInstructionEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ProcessingInstructionEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ProcessingInstructionEvents type, HtmlEventHandlerWithTarget<ProcessingInstruction> listener);

		public extern void RemoveEventListener(ProcessingInstructionEvents type, HtmlEventHandlerWithTarget<ProcessingInstruction> listener, bool capture);

		public extern void RemoveEventListener(ProcessingInstructionEvents type, IEventListener listener);

		public extern void RemoveEventListener(ProcessingInstructionEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ProcessingInstruction> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ProcessingInstruction> listener, bool capture);

		public readonly string Target;
	}
}
