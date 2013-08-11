// MapElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'MAP'"), ScriptName("Element")]
	public partial class MapElement : Element {
		internal MapElement() {
		}

		[IntrinsicProperty]
		public ElementCollection Areas {
			get { return default(ElementCollection); }
		}

		[IntrinsicProperty]
		public string Name {
			get { return null; }
			set { }
		}
	}
}
