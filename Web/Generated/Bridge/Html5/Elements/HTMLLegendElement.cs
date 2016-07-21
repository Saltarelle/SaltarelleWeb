namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLLegendElement : HTMLElement
	{
		internal extern HTMLLegendElement();

		public extern void AddEventListener(HTMLLegendElementEvents type, Action listener);

		public extern void AddEventListener(HTMLLegendElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLLegendElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLLegendElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLLegendElementEvents type, HtmlEventHandlerWithTarget<HTMLLegendElement> listener);

		public extern void AddEventListener(HTMLLegendElementEvents type, HtmlEventHandlerWithTarget<HTMLLegendElement> listener, bool capture);

		public extern void AddEventListener(HTMLLegendElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLLegendElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLLegendElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLLegendElement> listener, bool capture);

		public string Align;

		public readonly HTMLFormElement Form;

		public extern void RemoveEventListener(HTMLLegendElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLLegendElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLLegendElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLLegendElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLLegendElementEvents type, HtmlEventHandlerWithTarget<HTMLLegendElement> listener);

		public extern void RemoveEventListener(HTMLLegendElementEvents type, HtmlEventHandlerWithTarget<HTMLLegendElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLLegendElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLLegendElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLLegendElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLLegendElement> listener, bool capture);
	}
}
