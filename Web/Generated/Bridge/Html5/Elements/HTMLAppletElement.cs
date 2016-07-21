namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLAppletElement : HTMLElement
	{
		internal extern HTMLAppletElement();

		public extern void AddEventListener(HTMLAppletElementEvents type, Action listener);

		public extern void AddEventListener(HTMLAppletElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLAppletElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLAppletElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLAppletElementEvents type, HtmlEventHandlerWithTarget<HTMLAppletElement> listener);

		public extern void AddEventListener(HTMLAppletElementEvents type, HtmlEventHandlerWithTarget<HTMLAppletElement> listener, bool capture);

		public extern void AddEventListener(HTMLAppletElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLAppletElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLAppletElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLAppletElement> listener, bool capture);

		public string Align;

		public string Alt;

		public string Archive;

		public string Code;

		public string CodeBase;

		public string Height;

		public int Hspace;

		public string Name;

		public string Object;

		public extern void RemoveEventListener(HTMLAppletElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLAppletElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLAppletElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLAppletElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLAppletElementEvents type, HtmlEventHandlerWithTarget<HTMLAppletElement> listener);

		public extern void RemoveEventListener(HTMLAppletElementEvents type, HtmlEventHandlerWithTarget<HTMLAppletElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLAppletElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLAppletElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLAppletElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLAppletElement> listener, bool capture);

		public int Vspace;

		public string Width;
	}
}
