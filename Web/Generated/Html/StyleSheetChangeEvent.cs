// StyleSheetChangeEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class StyleSheetChangeEvent : Event {
		internal StyleSheetChangeEvent() {
		}

		public StyleSheetChangeEvent(string type) {
		}

		public StyleSheetChangeEvent(string type, StyleSheetChangeEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public bool DocumentSheet {
			get { return false; }
		}

		[IntrinsicProperty]
		public CSSStyleSheet Stylesheet {
			get { return default(CSSStyleSheet); }
		}
	}
}
