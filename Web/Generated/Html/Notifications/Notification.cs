using System.Runtime.CompilerServices;

namespace System.Html.Notifications {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class Notification : EventTarget {
		internal Notification() {
		}

		public Notification(string title) {
		}

		public Notification(string title, NotificationOptions options) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<Notification> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<Notification> listener, bool capture) {
		}

		public void Close() {
		}

		[IntrinsicProperty, ScriptName("onclick")]
		public HtmlEventHandler OnClick {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onclose")]
		public HtmlEventHandler OnClose {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onshow")]
		public HtmlEventHandler OnShow {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static NotificationPermission Permission {
			get {
				return default(NotificationPermission);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Notification> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Notification> listener, bool capture) {
		}

		public static void RequestPermission() {
		}

		public static void RequestPermission(NotificationPermissionCallback permissionCallback) {
		}
	}
}
