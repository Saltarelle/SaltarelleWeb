// Event.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class Event {
		internal Event() {
		}

		public Event(string type) {
		}

		public Event(string type, EventInit eventInitDict) {
		}

		[ScriptName("ALT_MASK")]
		public const int ALT_MASK = 1;

		[ScriptName("AT_TARGET")]
		public const ushort AT_TARGET = 2;

		[IntrinsicProperty]
		public bool Bubbles {
			get { return false; }
		}

		[ScriptName("BUBBLING_PHASE")]
		public const ushort BUBBLING_PHASE = 3;

		[IntrinsicProperty]
		public bool Cancelable {
			get { return false; }
		}

		[ScriptName("CAPTURING_PHASE")]
		public const ushort CAPTURING_PHASE = 1;

		[ScriptName("CONTROL_MASK")]
		public const int CONTROL_MASK = 2;

		[IntrinsicProperty]
		public EventTarget CurrentTarget {
			get { return default(EventTarget); }
		}

		[IntrinsicProperty]
		public bool DefaultPrevented {
			get { return false; }
		}

		[IntrinsicProperty]
		public EventPhase EventPhase {
			get { return default(EventPhase); }
		}

		[IntrinsicProperty]
		public EventTarget ExplicitOriginalTarget {
			get { return default(EventTarget); }
		}

		public bool GetPreventDefault() {
			return false;
		}

		[IntrinsicProperty]
		public bool IsTrusted {
			get { return false; }
		}

		[ScriptName("META_MASK")]
		public const int META_MASK = 8;

		public const ushort NONE = 0;

		[IntrinsicProperty]
		public EventTarget OriginalTarget {
			get { return default(EventTarget); }
		}

		public void PreventDefault() {
		}

		[ScriptName("SHIFT_MASK")]
		public const int SHIFT_MASK = 4;

		public void StopImmediatePropagation() {
		}

		public void StopPropagation() {
		}

		[IntrinsicProperty]
		public EventTarget Target {
			get { return default(EventTarget); }
		}

		[IntrinsicProperty]
		public long TimeStamp {
			get { return 0; }
		}

		[IntrinsicProperty]
		public string Type {
			get { return null; }
		}
	}
}
