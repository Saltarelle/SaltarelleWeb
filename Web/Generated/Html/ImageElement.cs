// ImageElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'IMG'"), ScriptName("Element")]
	public partial class ImageElement : Element {
		[InlineCode("new Image()")]
		public ImageElement() {
		}

		[InlineCode("new Image({width})")]
		public ImageElement(uint width) {
		}

		[InlineCode("new Image({width}, {height})")]
		public ImageElement(uint width, uint height) {
		}

		[IntrinsicProperty]
		public string Align {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Alt {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Border {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public bool Complete {
			get { return false; }
		}

		[IntrinsicProperty]
		public string CrossOrigin {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public uint Height {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public uint Hspace {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public bool IsMap {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public string LongDesc {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Lowsrc {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Name {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public uint NaturalHeight {
			get { return 0; }
		}

		[IntrinsicProperty]
		public uint NaturalWidth {
			get { return 0; }
		}

		[IntrinsicProperty]
		public string Src {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string UseMap {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public uint Width {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public uint Vspace {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public int X {
			get { return 0; }
		}

		[IntrinsicProperty]
		public int Y {
			get { return 0; }
		}
	}
}
