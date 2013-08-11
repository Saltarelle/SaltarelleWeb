// AudioElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'AUDIO'"), ScriptName("Element")]
	public partial class AudioElement : MediaElement {
		[InlineCode("new Audio()")]
		public AudioElement() {
		}

		[InlineCode("new Audio({src})")]
		public AudioElement(string src) {
		}
	}
}
