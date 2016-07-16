namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'METER'"), Name("Element")]
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

		[FieldProperty]
		public extern double High
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Low
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Max
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Min
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Optimum
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern double Value
		{
			get;
			set;
		}
	}
}
