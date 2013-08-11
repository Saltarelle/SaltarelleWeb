// NotificationOptions.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Notifications {
	[Imported, Serializable]
	public partial class NotificationOptions {
		public string Body {
			get { return null; }
			set { }
		}

		public NotificationDirection Dir {
			get { return default(NotificationDirection); }
			set { }
		}

		public string Icon {
			get { return null; }
			set { }
		}

		public string Lang {
			get { return null; }
			set { }
		}

		public string Tag {
			get { return null; }
			set { }
		}
	}
}
