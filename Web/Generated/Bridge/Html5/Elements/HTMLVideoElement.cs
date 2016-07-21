using Bridge.Html5.Media.Graphics;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLVideoElement : HTMLMediaElement
	{
		internal extern HTMLVideoElement();

		public extern void AddEventListener(HTMLVideoElementEvents type, Action listener);

		public extern void AddEventListener(HTMLVideoElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLVideoElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLVideoElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLVideoElementEvents type, HtmlEventHandlerWithTarget<HTMLVideoElement> listener);

		public extern void AddEventListener(HTMLVideoElementEvents type, HtmlEventHandlerWithTarget<HTMLVideoElement> listener, bool capture);

		public extern void AddEventListener(HTMLVideoElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLVideoElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLVideoElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLVideoElement> listener, bool capture);

		public extern VideoPlaybackQuality GetVideoPlaybackQuality();

		public int Height;

		public string Poster;

		public extern void RemoveEventListener(HTMLVideoElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLVideoElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLVideoElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLVideoElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLVideoElementEvents type, HtmlEventHandlerWithTarget<HTMLVideoElement> listener);

		public extern void RemoveEventListener(HTMLVideoElementEvents type, HtmlEventHandlerWithTarget<HTMLVideoElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLVideoElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLVideoElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLVideoElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLVideoElement> listener, bool capture);

		public readonly int VideoHeight;

		public readonly int VideoWidth;

		public int Width;
	}
}
