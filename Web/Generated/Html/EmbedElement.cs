// EmbedElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'EMBED'"), ScriptName("Element")]
	public partial class EmbedElement : Element {
		internal EmbedElement() {
		}

		[IntrinsicProperty]
		public string Align {
			get { return null; }
			set { }
		}

		[InlineCode("{this}({*arguments})")]
		public object Call(params object[] arguments) {
			return null;
		}

		public DocumentBase GetSVGDocument() {
			return default(DocumentBase);
		}

		[IntrinsicProperty]
		public string Height {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Name {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Src {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Type {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Width {
			get { return null; }
			set { }
		}
	}
}
