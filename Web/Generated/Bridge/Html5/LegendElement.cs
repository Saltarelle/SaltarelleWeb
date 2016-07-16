namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'LEGEND'"), Name("Element")]
	public partial class LegendElement : Element
	{
		internal extern LegendElement();

		public extern void AddEventListener(LegendElementEvents type, Action listener);

		public extern void AddEventListener(LegendElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(LegendElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(LegendElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(LegendElementEvents type, HtmlEventHandlerWithTarget<LegendElement> listener);

		public extern void AddEventListener(LegendElementEvents type, HtmlEventHandlerWithTarget<LegendElement> listener, bool capture);

		public extern void AddEventListener(LegendElementEvents type, IEventListener listener);

		public extern void AddEventListener(LegendElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<LegendElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<LegendElement> listener, bool capture);

		[FieldProperty]
		public extern string Align
		{
			get;
			set;
		}

		[FieldProperty]
		public extern FormElement Form
		{
			get;
		}

		public extern void RemoveEventListener(LegendElementEvents type, Action listener);

		public extern void RemoveEventListener(LegendElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(LegendElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(LegendElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(LegendElementEvents type, HtmlEventHandlerWithTarget<LegendElement> listener);

		public extern void RemoveEventListener(LegendElementEvents type, HtmlEventHandlerWithTarget<LegendElement> listener, bool capture);

		public extern void RemoveEventListener(LegendElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(LegendElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LegendElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LegendElement> listener, bool capture);
	}
}
