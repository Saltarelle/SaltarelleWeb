namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ConvolverNode : AudioNode
	{
		internal extern ConvolverNode();

		public extern void AddEventListener(ConvolverNodeEvents type, Action listener);

		public extern void AddEventListener(ConvolverNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(ConvolverNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ConvolverNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ConvolverNodeEvents type, HtmlEventHandlerWithTarget<ConvolverNode> listener);

		public extern void AddEventListener(ConvolverNodeEvents type, HtmlEventHandlerWithTarget<ConvolverNode> listener, bool capture);

		public extern void AddEventListener(ConvolverNodeEvents type, IEventListener listener);

		public extern void AddEventListener(ConvolverNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ConvolverNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ConvolverNode> listener, bool capture);

		public AudioBuffer Buffer;

		public bool Normalize;

		public extern void RemoveEventListener(ConvolverNodeEvents type, Action listener);

		public extern void RemoveEventListener(ConvolverNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ConvolverNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ConvolverNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ConvolverNodeEvents type, HtmlEventHandlerWithTarget<ConvolverNode> listener);

		public extern void RemoveEventListener(ConvolverNodeEvents type, HtmlEventHandlerWithTarget<ConvolverNode> listener, bool capture);

		public extern void RemoveEventListener(ConvolverNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(ConvolverNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ConvolverNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ConvolverNode> listener, bool capture);
	}
}
