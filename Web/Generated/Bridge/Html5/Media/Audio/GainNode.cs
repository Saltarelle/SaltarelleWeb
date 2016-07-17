namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External]
	public partial class GainNode : AudioNode
	{
		internal extern GainNode();

		public extern void AddEventListener(GainNodeEvents type, Action listener);

		public extern void AddEventListener(GainNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(GainNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(GainNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(GainNodeEvents type, HtmlEventHandlerWithTarget<GainNode> listener);

		public extern void AddEventListener(GainNodeEvents type, HtmlEventHandlerWithTarget<GainNode> listener, bool capture);

		public extern void AddEventListener(GainNodeEvents type, IEventListener listener);

		public extern void AddEventListener(GainNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<GainNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<GainNode> listener, bool capture);

		public readonly AudioParam Gain;

		public extern void RemoveEventListener(GainNodeEvents type, Action listener);

		public extern void RemoveEventListener(GainNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(GainNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(GainNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(GainNodeEvents type, HtmlEventHandlerWithTarget<GainNode> listener);

		public extern void RemoveEventListener(GainNodeEvents type, HtmlEventHandlerWithTarget<GainNode> listener, bool capture);

		public extern void RemoveEventListener(GainNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(GainNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<GainNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<GainNode> listener, bool capture);
	}
}
