using Bridge.Html5.Media.Graphics;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'VIDEO'"), Name("Element")]
	public partial class VideoElement : MediaElement
	{
		internal extern VideoElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<VideoElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<VideoElement> listener, bool capture);

		public extern void AddEventListener(VideoElementEvents type, Action listener);

		public extern void AddEventListener(VideoElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(VideoElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(VideoElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(VideoElementEvents type, HtmlEventHandlerWithTarget<VideoElement> listener);

		public extern void AddEventListener(VideoElementEvents type, HtmlEventHandlerWithTarget<VideoElement> listener, bool capture);

		public extern void AddEventListener(VideoElementEvents type, IEventListener listener);

		public extern void AddEventListener(VideoElementEvents type, IEventListener listener, bool capture);

		public extern VideoPlaybackQuality GetVideoPlaybackQuality();

		[FieldProperty]
		public extern int Height
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Poster
		{
			get;
			set;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<VideoElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<VideoElement> listener, bool capture);

		public extern void RemoveEventListener(VideoElementEvents type, Action listener);

		public extern void RemoveEventListener(VideoElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(VideoElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(VideoElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(VideoElementEvents type, HtmlEventHandlerWithTarget<VideoElement> listener);

		public extern void RemoveEventListener(VideoElementEvents type, HtmlEventHandlerWithTarget<VideoElement> listener, bool capture);

		public extern void RemoveEventListener(VideoElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(VideoElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern int VideoHeight
		{
			get;
		}

		[FieldProperty]
		public extern int VideoWidth
		{
			get;
		}

		[FieldProperty]
		public extern int Width
		{
			get;
			set;
		}
	}
}
