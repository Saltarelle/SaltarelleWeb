using Bridge.Html5.Media.Audio;

namespace Bridge.Html5.Media.Source
{
	[Namespace(false), External]
	public partial class MediaSource : EventTarget
	{
		public extern MediaSource();

		public readonly SourceBufferList ActiveSourceBuffers;

		public extern void AddEventListener(MediaSourceEvents type, Action listener);

		public extern void AddEventListener(MediaSourceEvents type, Action listener, bool capture);

		public extern void AddEventListener(MediaSourceEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(MediaSourceEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(MediaSourceEvents type, HtmlEventHandlerWithTarget<MediaSource> listener);

		public extern void AddEventListener(MediaSourceEvents type, HtmlEventHandlerWithTarget<MediaSource> listener, bool capture);

		public extern void AddEventListener(MediaSourceEvents type, IEventListener listener);

		public extern void AddEventListener(MediaSourceEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaSource> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaSource> listener, bool capture);

		public extern SourceBuffer AddSourceBuffer(string type);

		public double Duration;

		public extern void EndOfStream();

		public extern void EndOfStream(MediaSourceEndOfStreamError error);

		public static extern bool IsTypeSupported(string type);

		public readonly MediaSourceReadyState ReadyState;

		public extern void RemoveEventListener(MediaSourceEvents type, Action listener);

		public extern void RemoveEventListener(MediaSourceEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(MediaSourceEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(MediaSourceEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(MediaSourceEvents type, HtmlEventHandlerWithTarget<MediaSource> listener);

		public extern void RemoveEventListener(MediaSourceEvents type, HtmlEventHandlerWithTarget<MediaSource> listener, bool capture);

		public extern void RemoveEventListener(MediaSourceEvents type, IEventListener listener);

		public extern void RemoveEventListener(MediaSourceEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaSource> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaSource> listener, bool capture);

		public extern void RemoveSourceBuffer(SourceBuffer sourceBuffer);

		public readonly SourceBufferList SourceBuffers;
	}
}
