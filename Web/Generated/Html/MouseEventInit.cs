using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class MouseEventInit {
		public bool AltKey {
			get;
			set;
		}

		public bool Bubbles {
			get;
			set;
		}

		public short Button {
			get;
			set;
		}

		public ushort Buttons {
			get;
			set;
		}

		public bool Cancelable {
			get;
			set;
		}

		public int ClientX {
			get;
			set;
		}

		public int ClientY {
			get;
			set;
		}

		public bool CtrlKey {
			get;
			set;
		}

		public int Detail {
			get;
			set;
		}

		public bool MetaKey {
			get;
			set;
		}

		public EventTarget RelatedTarget {
			get;
			set;
		}

		public int ScreenX {
			get;
			set;
		}

		public int ScreenY {
			get;
			set;
		}

		public bool ShiftKey {
			get;
			set;
		}

		public WindowInstance View {
			get;
			set;
		}
	}
}
