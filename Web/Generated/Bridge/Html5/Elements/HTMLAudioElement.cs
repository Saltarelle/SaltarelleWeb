namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLAudioElement : HTMLMediaElement
	{
		[Template("new Audio()")]
		public extern HTMLAudioElement();

		[Template("new Audio({src})")]
		public extern HTMLAudioElement(string src);

		public extern void AddEventListener(HTMLAudioElementEvents type, Action listener);

		public extern void AddEventListener(HTMLAudioElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLAudioElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLAudioElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLAudioElementEvents type, HtmlEventHandlerWithTarget<HTMLAudioElement> listener);

		public extern void AddEventListener(HTMLAudioElementEvents type, HtmlEventHandlerWithTarget<HTMLAudioElement> listener, bool capture);

		public extern void AddEventListener(HTMLAudioElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLAudioElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLAudioElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLAudioElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLAudioElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLAudioElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLAudioElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLAudioElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLAudioElementEvents type, HtmlEventHandlerWithTarget<HTMLAudioElement> listener);

		public extern void RemoveEventListener(HTMLAudioElementEvents type, HtmlEventHandlerWithTarget<HTMLAudioElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLAudioElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLAudioElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLAudioElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLAudioElement> listener, bool capture);
	}
}
