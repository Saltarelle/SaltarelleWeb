namespace Bridge.Html5.Notifications
{
	[Namespace(false), External]
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

		public readonly string Body;

		public extern void Close();

		public readonly NotificationDirection Dir;

		public readonly string Icon;

		public readonly string Lang;

		[Name("onclick")]
		public HtmlEventHandler OnClick;

		[Name("onclose")]
		public HtmlEventHandler OnClose;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onshow")]
		public HtmlEventHandler OnShow;

		public readonly NotificationPermission Permission;

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

		public readonly string Tag;

		public readonly string Title;
	}
}
