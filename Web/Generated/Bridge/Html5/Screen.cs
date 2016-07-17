namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class Screen : EventTarget
	{
		internal extern Screen();

		public extern void AddEventListener(ScreenEvents type, Action listener);

		public extern void AddEventListener(ScreenEvents type, Action listener, bool capture);

		public extern void AddEventListener(ScreenEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ScreenEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ScreenEvents type, HtmlEventHandlerWithTarget<Screen> listener);

		public extern void AddEventListener(ScreenEvents type, HtmlEventHandlerWithTarget<Screen> listener, bool capture);

		public extern void AddEventListener(ScreenEvents type, IEventListener listener);

		public extern void AddEventListener(ScreenEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Screen> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Screen> listener, bool capture);

		public readonly int AvailHeight;

		public readonly int AvailLeft;

		public readonly int AvailTop;

		public readonly int AvailWidth;

		public readonly int ColorDepth;

		public readonly int Height;

		public readonly int Left;

		public readonly int PixelDepth;

		public extern void RemoveEventListener(ScreenEvents type, Action listener);

		public extern void RemoveEventListener(ScreenEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ScreenEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ScreenEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ScreenEvents type, HtmlEventHandlerWithTarget<Screen> listener);

		public extern void RemoveEventListener(ScreenEvents type, HtmlEventHandlerWithTarget<Screen> listener, bool capture);

		public extern void RemoveEventListener(ScreenEvents type, IEventListener listener);

		public extern void RemoveEventListener(ScreenEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Screen> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Screen> listener, bool capture);

		public readonly int Top;

		public readonly int Width;
	}
}
