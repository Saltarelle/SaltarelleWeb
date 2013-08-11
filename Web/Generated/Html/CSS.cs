// CSS.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CSS {
		internal CSS() {
		}

		public static bool Supports(string conditionText) {
			return false;
		}

		public static bool Supports(string property, string value) {
			return false;
		}
	}
}
