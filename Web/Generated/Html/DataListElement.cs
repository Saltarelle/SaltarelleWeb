// DataListElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'DATALIST'"), ScriptName("Element")]
	public partial class DataListElement : Element {
		internal DataListElement() {
		}

		[IntrinsicProperty]
		public ElementCollection Options {
			get { return default(ElementCollection); }
		}
	}
}
