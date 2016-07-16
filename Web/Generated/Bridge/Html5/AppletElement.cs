namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'APPLET'"), Name("Element")]
	public partial class AppletElement : Element
	{
		internal extern AppletElement();

		public extern void AddEventListener(AppletElementEvents type, Action listener);

		public extern void AddEventListener(AppletElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(AppletElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(AppletElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(AppletElementEvents type, HtmlEventHandlerWithTarget<AppletElement> listener);

		public extern void AddEventListener(AppletElementEvents type, HtmlEventHandlerWithTarget<AppletElement> listener, bool capture);

		public extern void AddEventListener(AppletElementEvents type, IEventListener listener);

		public extern void AddEventListener(AppletElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AppletElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AppletElement> listener, bool capture);

		[FieldProperty]
		public extern string Align
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Alt
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Archive
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Code
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string CodeBase
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Height
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int Hspace
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Object
		{
			get;
			set;
		}

		public extern void RemoveEventListener(AppletElementEvents type, Action listener);

		public extern void RemoveEventListener(AppletElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(AppletElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(AppletElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(AppletElementEvents type, HtmlEventHandlerWithTarget<AppletElement> listener);

		public extern void RemoveEventListener(AppletElementEvents type, HtmlEventHandlerWithTarget<AppletElement> listener, bool capture);

		public extern void RemoveEventListener(AppletElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(AppletElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AppletElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AppletElement> listener, bool capture);

		[FieldProperty]
		public extern int Vspace
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Width
		{
			get;
			set;
		}
	}
}
