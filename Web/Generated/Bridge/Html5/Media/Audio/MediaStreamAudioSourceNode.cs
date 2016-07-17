namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External]
	public partial class MediaStreamAudioSourceNode : AudioNode
	{
		internal extern MediaStreamAudioSourceNode();

		public extern void AddEventListener(MediaStreamAudioSourceNodeEvents type, Action listener);

		public extern void AddEventListener(MediaStreamAudioSourceNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(MediaStreamAudioSourceNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(MediaStreamAudioSourceNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(MediaStreamAudioSourceNodeEvents type, HtmlEventHandlerWithTarget<MediaStreamAudioSourceNode> listener);

		public extern void AddEventListener(MediaStreamAudioSourceNodeEvents type, HtmlEventHandlerWithTarget<MediaStreamAudioSourceNode> listener, bool capture);

		public extern void AddEventListener(MediaStreamAudioSourceNodeEvents type, IEventListener listener);

		public extern void AddEventListener(MediaStreamAudioSourceNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaStreamAudioSourceNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaStreamAudioSourceNode> listener, bool capture);

		public extern void RemoveEventListener(MediaStreamAudioSourceNodeEvents type, Action listener);

		public extern void RemoveEventListener(MediaStreamAudioSourceNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(MediaStreamAudioSourceNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(MediaStreamAudioSourceNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(MediaStreamAudioSourceNodeEvents type, HtmlEventHandlerWithTarget<MediaStreamAudioSourceNode> listener);

		public extern void RemoveEventListener(MediaStreamAudioSourceNodeEvents type, HtmlEventHandlerWithTarget<MediaStreamAudioSourceNode> listener, bool capture);

		public extern void RemoveEventListener(MediaStreamAudioSourceNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(MediaStreamAudioSourceNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaStreamAudioSourceNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaStreamAudioSourceNode> listener, bool capture);
	}
}
