namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class LabelElement : Element
	{
		internal extern LabelElement();

		public extern void AddEventListener(LabelElementEvents type, Action listener);

		public extern void AddEventListener(LabelElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(LabelElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(LabelElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(LabelElementEvents type, HtmlEventHandlerWithTarget<LabelElement> listener);

		public extern void AddEventListener(LabelElementEvents type, HtmlEventHandlerWithTarget<LabelElement> listener, bool capture);

		public extern void AddEventListener(LabelElementEvents type, IEventListener listener);

		public extern void AddEventListener(LabelElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<LabelElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<LabelElement> listener, bool capture);

		public readonly Element Control;

		public readonly FormElement Form;

		public string HtmlFor;

		public extern void RemoveEventListener(LabelElementEvents type, Action listener);

		public extern void RemoveEventListener(LabelElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(LabelElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(LabelElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(LabelElementEvents type, HtmlEventHandlerWithTarget<LabelElement> listener);

		public extern void RemoveEventListener(LabelElementEvents type, HtmlEventHandlerWithTarget<LabelElement> listener, bool capture);

		public extern void RemoveEventListener(LabelElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(LabelElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LabelElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LabelElement> listener, bool capture);
	}
}
