// CSSStyleSheet.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CSSStyleSheet : StyleSheet {
		internal CSSStyleSheet() {
		}

		[IntrinsicProperty]
		public CSSRule[] CssRules {
			get { return null; }
		}

		public void DeleteRule(uint index) {
		}

		public uint InsertRule(string rule, uint index) {
			return 0;
		}

		[IntrinsicProperty]
		public CSSRule OwnerRule {
			get { return default(CSSRule); }
		}
	}
}
