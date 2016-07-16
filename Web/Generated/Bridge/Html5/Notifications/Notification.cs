namespace Bridge.Html5.Notifications
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Notification : EventTarget
	{
		internal extern Notification();

		public extern Notification(string title);

		public extern Notification(string title, NotificationOptions options);

		public extern void AddEventListener(NotificationEvents type, Action listener);

		public extern void AddEventListener(NotificationEvents type, Action listener, bool capture);

		public extern void AddEventListener(NotificationEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(NotificationEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(NotificationEvents type, HtmlEventHandlerWithTarget<Notification> listener);

		public extern void AddEventListener(NotificationEvents type, HtmlEventHandlerWithTarget<Notification> listener, bool capture);

		public extern void AddEventListener(NotificationEvents type, IEventListener listener);

		public extern void AddEventListener(NotificationEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Notification> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Notification> listener, bool capture);

		[FieldProperty]
		public extern string Body
		{
			get;
		}

		public extern void Close();

		[FieldProperty]
		public extern NotificationDirection Dir
		{
			get;
		}

		[FieldProperty]
		public extern string Icon
		{
			get;
		}

		[FieldProperty]
		public extern string Lang
		{
			get;
		}

		[FieldProperty, Name("onclick")]
		public extern HtmlEventHandler OnClick
		{
			get;
			set;
		}

		[FieldProperty, Name("onclose")]
		public extern HtmlEventHandler OnClose
		{
			get;
			set;
		}

		[FieldProperty, Name("onerror")]
		public extern HtmlEventHandler OnError
		{
			get;
			set;
		}

		[FieldProperty, Name("onshow")]
		public extern HtmlEventHandler OnShow
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern NotificationPermission Permission
		{
			get;
		}

		public extern void RemoveEventListener(NotificationEvents type, Action listener);

		public extern void RemoveEventListener(NotificationEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(NotificationEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(NotificationEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(NotificationEvents type, HtmlEventHandlerWithTarget<Notification> listener);

		public extern void RemoveEventListener(NotificationEvents type, HtmlEventHandlerWithTarget<Notification> listener, bool capture);

		public extern void RemoveEventListener(NotificationEvents type, IEventListener listener);

		public extern void RemoveEventListener(NotificationEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Notification> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Notification> listener, bool capture);

		public static extern void RequestPermission();

		public static extern void RequestPermission(NotificationPermissionCallback permissionCallback);

		[FieldProperty]
		public extern string Tag
		{
			get;
		}

		[FieldProperty]
		public extern string Title
		{
			get;
		}
	}
}
