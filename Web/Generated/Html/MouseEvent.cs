// MouseEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MouseEvent : UIEvent {
		internal MouseEvent() {
		}

		public MouseEvent(string typeArg) {
		}

		public MouseEvent(string typeArg, MouseEventInit mouseEventInitDict) {
		}

		[IntrinsicProperty]
		public bool AltKey {
			get { return false; }
		}

		[IntrinsicProperty]
		public ushort Button {
			get { return 0; }
		}

		[IntrinsicProperty]
		public ushort Buttons {
			get { return 0; }
		}

		[IntrinsicProperty]
		public int ClientX {
			get { return 0; }
		}

		[IntrinsicProperty]
		public int ClientY {
			get { return 0; }
		}

		[IntrinsicProperty]
		public bool CtrlKey {
			get { return false; }
		}

		public bool GetModifierState(string keyArg) {
			return false;
		}

		[IntrinsicProperty]
		public bool MetaKey {
			get { return false; }
		}

		[IntrinsicProperty]
		public EventTarget RelatedTarget {
			get { return default(EventTarget); }
		}

		[IntrinsicProperty]
		public int ScreenX {
			get { return 0; }
		}

		[IntrinsicProperty]
		public int ScreenY {
			get { return 0; }
		}

		[IntrinsicProperty]
		public bool ShiftKey {
			get { return false; }
		}
	}
}
