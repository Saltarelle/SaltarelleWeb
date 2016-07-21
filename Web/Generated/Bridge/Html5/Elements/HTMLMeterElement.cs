namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLMeterElement : HTMLElement
	{
		internal extern HTMLMeterElement();

		public extern void AddEventListener(HTMLMeterElementEvents type, Action listener);

		public extern void AddEventListener(HTMLMeterElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLMeterElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLMeterElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLMeterElementEvents type, HtmlEventHandlerWithTarget<HTMLMeterElement> listener);

		public extern void AddEventListener(HTMLMeterElementEvents type, HtmlEventHandlerWithTarget<HTMLMeterElement> listener, bool capture);

		public extern void AddEventListener(HTMLMeterElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLMeterElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLMeterElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLMeterElement> listener, bool capture);

		public double High;

		public double Low;

		public double Max;

		public double Min;

		public double Optimum;

		public extern void RemoveEventListener(HTMLMeterElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLMeterElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLMeterElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLMeterElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLMeterElementEvents type, HtmlEventHandlerWithTarget<HTMLMeterElement> listener);

		public extern void RemoveEventListener(HTMLMeterElementEvents type, HtmlEventHandlerWithTarget<HTMLMeterElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLMeterElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLMeterElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLMeterElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLMeterElement> listener, bool capture);

		public double Value;
	}
}
