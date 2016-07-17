namespace Bridge.Html5
{
	[Namespace(false), External, Name("Element")]
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

		public string Align;

		public string Alt;

		public string Archive;

		public string Code;

		public string CodeBase;

		public string Height;

		public int Hspace;

		public string Name;

		public string Object;

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

		public int Vspace;

		public string Width;
	}
}
