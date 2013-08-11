// TimeElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TIME'"), ScriptName("Element")]
	public partial class TimeElement : Element {
		internal TimeElement() {
		}

		[IntrinsicProperty]
		public string DateTime {
			get { return null; }
			set { }
		}
	}
}
