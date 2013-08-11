// StyleRuleChangeEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class StyleRuleChangeEvent : Event {
		internal StyleRuleChangeEvent() {
		}

		public StyleRuleChangeEvent(string type) {
		}

		public StyleRuleChangeEvent(string type, StyleRuleChangeEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public CSSRule Rule {
			get { return default(CSSRule); }
		}

		[IntrinsicProperty]
		public CSSStyleSheet Stylesheet {
			get { return default(CSSStyleSheet); }
		}
	}
}
