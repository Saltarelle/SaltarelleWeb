namespace Bridge.Html5
{
	[Namespace(false), External, Name("Element")]
	public partial class MeterElement : Element
	{
		internal extern MeterElement();

		public extern void AddEventListener(MeterElementEvents type, Action listener);

		public extern void AddEventListener(MeterElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(MeterElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(MeterElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(MeterElementEvents type, HtmlEventHandlerWithTarget<MeterElement> listener);

		public extern void AddEventListener(MeterElementEvents type, HtmlEventHandlerWithTarget<MeterElement> listener, bool capture);

		public extern void AddEventListener(MeterElementEvents type, IEventListener listener);

		public extern void AddEventListener(MeterElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MeterElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MeterElement> listener, bool capture);

		public double High;

		public double Low;

		public double Max;

		public double Min;

		public double Optimum;

		public extern void RemoveEventListener(MeterElementEvents type, Action listener);

		public extern void RemoveEventListener(MeterElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(MeterElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(MeterElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(MeterElementEvents type, HtmlEventHandlerWithTarget<MeterElement> listener);

		public extern void RemoveEventListener(MeterElementEvents type, HtmlEventHandlerWithTarget<MeterElement> listener, bool capture);

		public extern void RemoveEventListener(MeterElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(MeterElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MeterElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MeterElement> listener, bool capture);

		public double Value;
	}
}
