// MouseEventInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class MouseEventInit {
		public bool AltKey {
			get { return false; }
			set { }
		}

		public bool Bubbles {
			get { return false; }
			set { }
		}

		public ushort Button {
			get { return 0; }
			set { }
		}

		public ushort Buttons {
			get { return 0; }
			set { }
		}

		public bool Cancelable {
			get { return false; }
			set { }
		}

		public int ClientX {
			get { return 0; }
			set { }
		}

		public int ClientY {
			get { return 0; }
			set { }
		}

		public bool CtrlKey {
			get { return false; }
			set { }
		}

		public int Detail {
			get { return 0; }
			set { }
		}

		public bool MetaKey {
			get { return false; }
			set { }
		}

		public EventTarget RelatedTarget {
			get { return default(EventTarget); }
			set { }
		}

		public int ScreenX {
			get { return 0; }
			set { }
		}

		public int ScreenY {
			get { return 0; }
			set { }
		}

		public bool ShiftKey {
			get { return false; }
			set { }
		}

		public WindowInstance View {
			get { return default(WindowInstance); }
			set { }
		}
	}
}
