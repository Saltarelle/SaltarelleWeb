// Notification.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

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

		public void Close() {
		}

		[IntrinsicProperty, ScriptName("onclick")]
		public HtmlEventHandler OnClick {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onclose")]
		public HtmlEventHandler OnClose {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onshow")]
		public HtmlEventHandler OnShow {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty]
		public static NotificationPermission Permission {
			get { return default(NotificationPermission); }
		}

		public static void RequestPermission() {
		}

		public static void RequestPermission(NotificationPermissionCallback permissionCallback) {
		}
	}
}
