namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MediaStreamAudioDestinationNode : AudioNode
	{
		internal extern MediaStreamAudioDestinationNode();

		public extern void AddEventListener(MediaStreamAudioDestinationNodeEvents type, Action listener);

		public extern void AddEventListener(MediaStreamAudioDestinationNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(MediaStreamAudioDestinationNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(MediaStreamAudioDestinationNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(MediaStreamAudioDestinationNodeEvents type, HtmlEventHandlerWithTarget<MediaStreamAudioDestinationNode> listener);

		public extern void AddEventListener(MediaStreamAudioDestinationNodeEvents type, HtmlEventHandlerWithTarget<MediaStreamAudioDestinationNode> listener, bool capture);

		public extern void AddEventListener(MediaStreamAudioDestinationNodeEvents type, IEventListener listener);

		public extern void AddEventListener(MediaStreamAudioDestinationNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaStreamAudioDestinationNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaStreamAudioDestinationNode> listener, bool capture);

		public extern void RemoveEventListener(MediaStreamAudioDestinationNodeEvents type, Action listener);

		public extern void RemoveEventListener(MediaStreamAudioDestinationNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(MediaStreamAudioDestinationNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(MediaStreamAudioDestinationNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(MediaStreamAudioDestinationNodeEvents type, HtmlEventHandlerWithTarget<MediaStreamAudioDestinationNode> listener);

		public extern void RemoveEventListener(MediaStreamAudioDestinationNodeEvents type, HtmlEventHandlerWithTarget<MediaStreamAudioDestinationNode> listener, bool capture);

		public extern void RemoveEventListener(MediaStreamAudioDestinationNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(MediaStreamAudioDestinationNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaStreamAudioDestinationNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaStreamAudioDestinationNode> listener, bool capture);

		public readonly MediaStream Stream;
	}
}
