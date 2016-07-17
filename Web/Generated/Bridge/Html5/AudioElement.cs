namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class AudioElement : MediaElement
	{
		[Template("new Audio()")]
		public extern AudioElement();

		[Template("new Audio({src})")]
		public extern AudioElement(string src);

		public extern void AddEventListener(AudioElementEvents type, Action listener);

		public extern void AddEventListener(AudioElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(AudioElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(AudioElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(AudioElementEvents type, HtmlEventHandlerWithTarget<AudioElement> listener);

		public extern void AddEventListener(AudioElementEvents type, HtmlEventHandlerWithTarget<AudioElement> listener, bool capture);

		public extern void AddEventListener(AudioElementEvents type, IEventListener listener);

		public extern void AddEventListener(AudioElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioElement> listener, bool capture);

		public extern void RemoveEventListener(AudioElementEvents type, Action listener);

		public extern void RemoveEventListener(AudioElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(AudioElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(AudioElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(AudioElementEvents type, HtmlEventHandlerWithTarget<AudioElement> listener);

		public extern void RemoveEventListener(AudioElementEvents type, HtmlEventHandlerWithTarget<AudioElement> listener, bool capture);

		public extern void RemoveEventListener(AudioElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(AudioElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioElement> listener, bool capture);
	}
}
