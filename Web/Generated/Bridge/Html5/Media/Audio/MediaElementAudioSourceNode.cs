namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MediaElementAudioSourceNode : AudioNode
	{
		internal extern MediaElementAudioSourceNode();

		public extern void AddEventListener(MediaElementAudioSourceNodeEvents type, Action listener);

		public extern void AddEventListener(MediaElementAudioSourceNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(MediaElementAudioSourceNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(MediaElementAudioSourceNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(MediaElementAudioSourceNodeEvents type, HtmlEventHandlerWithTarget<MediaElementAudioSourceNode> listener);

		public extern void AddEventListener(MediaElementAudioSourceNodeEvents type, HtmlEventHandlerWithTarget<MediaElementAudioSourceNode> listener, bool capture);

		public extern void AddEventListener(MediaElementAudioSourceNodeEvents type, IEventListener listener);

		public extern void AddEventListener(MediaElementAudioSourceNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaElementAudioSourceNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaElementAudioSourceNode> listener, bool capture);

		public extern void RemoveEventListener(MediaElementAudioSourceNodeEvents type, Action listener);

		public extern void RemoveEventListener(MediaElementAudioSourceNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(MediaElementAudioSourceNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(MediaElementAudioSourceNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(MediaElementAudioSourceNodeEvents type, HtmlEventHandlerWithTarget<MediaElementAudioSourceNode> listener);

		public extern void RemoveEventListener(MediaElementAudioSourceNodeEvents type, HtmlEventHandlerWithTarget<MediaElementAudioSourceNode> listener, bool capture);

		public extern void RemoveEventListener(MediaElementAudioSourceNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(MediaElementAudioSourceNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaElementAudioSourceNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaElementAudioSourceNode> listener, bool capture);
	}
}
