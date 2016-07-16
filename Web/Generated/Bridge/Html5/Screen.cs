namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
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

		[FieldProperty]
		public extern int AvailHeight
		{
			get;
		}

		[FieldProperty]
		public extern int AvailLeft
		{
			get;
		}

		[FieldProperty]
		public extern int AvailTop
		{
			get;
		}

		[FieldProperty]
		public extern int AvailWidth
		{
			get;
		}

		[FieldProperty]
		public extern int ColorDepth
		{
			get;
		}

		[FieldProperty]
		public extern int Height
		{
			get;
		}

		[FieldProperty]
		public extern int Left
		{
			get;
		}

		[FieldProperty]
		public extern int PixelDepth
		{
			get;
		}

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

		[FieldProperty]
		public extern int Top
		{
			get;
		}

		[FieldProperty]
		public extern int Width
		{
			get;
		}
	}
}
