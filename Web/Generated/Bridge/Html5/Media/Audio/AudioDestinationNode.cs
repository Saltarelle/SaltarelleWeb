namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External]
	public partial class AudioDestinationNode : AudioNode
	{
		internal extern AudioDestinationNode();

		public extern void AddEventListener(AudioDestinationNodeEvents type, Action listener);

		public extern void AddEventListener(AudioDestinationNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(AudioDestinationNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(AudioDestinationNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(AudioDestinationNodeEvents type, HtmlEventHandlerWithTarget<AudioDestinationNode> listener);

		public extern void AddEventListener(AudioDestinationNodeEvents type, HtmlEventHandlerWithTarget<AudioDestinationNode> listener, bool capture);

		public extern void AddEventListener(AudioDestinationNodeEvents type, IEventListener listener);

		public extern void AddEventListener(AudioDestinationNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioDestinationNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioDestinationNode> listener, bool capture);

		public readonly int MaxChannelCount;

		public extern void RemoveEventListener(AudioDestinationNodeEvents type, Action listener);

		public extern void RemoveEventListener(AudioDestinationNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(AudioDestinationNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(AudioDestinationNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(AudioDestinationNodeEvents type, HtmlEventHandlerWithTarget<AudioDestinationNode> listener);

		public extern void RemoveEventListener(AudioDestinationNodeEvents type, HtmlEventHandlerWithTarget<AudioDestinationNode> listener, bool capture);

		public extern void RemoveEventListener(AudioDestinationNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(AudioDestinationNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioDestinationNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioDestinationNode> listener, bool capture);
	}
}
