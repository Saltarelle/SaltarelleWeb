// FrameElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FRAME'"), ScriptName("Element")]
	public partial class FrameElement : Element {
		internal FrameElement() {
		}

		[IntrinsicProperty]
		public DocumentBase ContentDocument {
			get { return default(DocumentBase); }
		}

		[IntrinsicProperty]
		public WindowInstance ContentWindow {
			get { return default(WindowInstance); }
		}

		[IntrinsicProperty]
		public string FrameBorder {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string LongDesc {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string MarginHeight {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string MarginWidth {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Name {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public bool NoResize {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public string Scrolling {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Src {
			get { return null; }
			set { }
		}
	}
}
