// FocusEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class FocusEvent : UIEvent {
		internal FocusEvent() {
		}

		public FocusEvent(string typeArg) {
		}

		public FocusEvent(string typeArg, FocusEventInit focusEventInitDict) {
		}

		[IntrinsicProperty]
		public EventTarget RelatedTarget {
			get { return default(EventTarget); }
		}
	}
}
