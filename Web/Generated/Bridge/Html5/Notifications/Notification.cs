namespace Bridge.Html5.Notifications
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Notification : EventTarget
	{
		internal Notification()
		{
		}

		public Notification(string title)
		{
		}

		public Notification(string title, NotificationOptions options)
		{
		}

		public void AddEventListener(NotificationEvents type, Action listener)
		{
		}

		public void AddEventListener(NotificationEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(NotificationEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(NotificationEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(NotificationEvents type, HtmlEventHandlerWithTarget<Notification> listener)
		{
		}

		public void AddEventListener(NotificationEvents type, HtmlEventHandlerWithTarget<Notification> listener, bool capture)
		{
		}

		public void AddEventListener(NotificationEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(NotificationEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Notification> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Notification> listener, bool capture)
		{
		}

		[FieldProperty]
		public string Body
		{
			get {
				return null;
			}
		}

		public void Close()
		{
		}

		[FieldProperty]
		public NotificationDirection Dir
		{
			get {
				return default(NotificationDirection);
			}
		}

		[FieldProperty]
		public string Icon
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string Lang
		{
			get {
				return null;
			}
		}

		[FieldProperty, Name("onclick")]
		public HtmlEventHandler OnClick
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onclose")]
		public HtmlEventHandler OnClose
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onerror")]
		public HtmlEventHandler OnError
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onshow")]
		public HtmlEventHandler OnShow
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty]
		public static NotificationPermission Permission
		{
			get {
				return default(NotificationPermission);
			}
		}

		public void RemoveEventListener(NotificationEvents type, Action listener)
		{
		}

		public void RemoveEventListener(NotificationEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(NotificationEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(NotificationEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(NotificationEvents type, HtmlEventHandlerWithTarget<Notification> listener)
		{
		}

		public void RemoveEventListener(NotificationEvents type, HtmlEventHandlerWithTarget<Notification> listener, bool capture)
		{
		}

		public void RemoveEventListener(NotificationEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(NotificationEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Notification> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Notification> listener, bool capture)
		{
		}

		public static void RequestPermission()
		{
		}

		public static void RequestPermission(NotificationPermissionCallback permissionCallback)
		{
		}

		[FieldProperty]
		public string Tag
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string Title
		{
			get {
				return null;
			}
		}
	}
}
