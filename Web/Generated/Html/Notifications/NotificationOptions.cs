using System.Runtime.CompilerServices;

namespace System.Html.Notifications {
	[Imported, Serializable]
	public partial class NotificationOptions {
		public string Body {
			get;
			set;
		}

		public NotificationDirection Dir {
			get;
			set;
		}

		public string Icon {
			get;
			set;
		}

		public string Lang {
			get;
			set;
		}

		public string Tag {
			get;
			set;
		}
	}
}
