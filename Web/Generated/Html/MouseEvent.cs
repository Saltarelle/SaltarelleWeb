﻿using System.Runtime.CompilerServices;

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
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public short Button {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ushort Buttons {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int ClientX {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int ClientY {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public bool CtrlKey {
			get {
				return false;
			}
		}

		public bool GetModifierState(string keyArg) {
			return false;
		}

		public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, WindowInstance viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg, EventTarget relatedTargetArg) {
		}

		[IntrinsicProperty]
		public bool MetaKey {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public EventTarget RelatedTarget {
			get {
				return default(EventTarget);
			}
		}

		[IntrinsicProperty]
		public int ScreenX {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int ScreenY {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public bool ShiftKey {
			get {
				return false;
			}
		}
	}
}
