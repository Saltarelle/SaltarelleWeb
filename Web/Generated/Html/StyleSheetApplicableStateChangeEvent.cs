// StyleSheetApplicableStateChangeEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class StyleSheetApplicableStateChangeEvent : Event {
		internal StyleSheetApplicableStateChangeEvent() {
		}

		public StyleSheetApplicableStateChangeEvent(string type) {
		}

		public StyleSheetApplicableStateChangeEvent(string type, StyleSheetApplicableStateChangeEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public bool Applicable {
			get { return false; }
		}

		[IntrinsicProperty]
		public CSSStyleSheet Stylesheet {
			get { return default(CSSStyleSheet); }
		}
	}
}
