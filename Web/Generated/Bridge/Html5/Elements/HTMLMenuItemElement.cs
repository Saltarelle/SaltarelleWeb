namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLMenuItemElement : HTMLElement
	{
		internal extern HTMLMenuItemElement();

		public extern void AddEventListener(HTMLMenuItemElementEvents type, Action listener);

		public extern void AddEventListener(HTMLMenuItemElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLMenuItemElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLMenuItemElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLMenuItemElementEvents type, HtmlEventHandlerWithTarget<HTMLMenuItemElement> listener);

		public extern void AddEventListener(HTMLMenuItemElementEvents type, HtmlEventHandlerWithTarget<HTMLMenuItemElement> listener, bool capture);

		public extern void AddEventListener(HTMLMenuItemElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLMenuItemElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLMenuItemElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLMenuItemElement> listener, bool capture);

		public bool Checked;

		public bool DefaultChecked;

		public bool Disabled;

		public string Icon;

		public string Label;

		public string Radiogroup;

		public extern void RemoveEventListener(HTMLMenuItemElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLMenuItemElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLMenuItemElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLMenuItemElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLMenuItemElementEvents type, HtmlEventHandlerWithTarget<HTMLMenuItemElement> listener);

		public extern void RemoveEventListener(HTMLMenuItemElementEvents type, HtmlEventHandlerWithTarget<HTMLMenuItemElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLMenuItemElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLMenuItemElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLMenuItemElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLMenuItemElement> listener, bool capture);

		public string Type;
	}
}
