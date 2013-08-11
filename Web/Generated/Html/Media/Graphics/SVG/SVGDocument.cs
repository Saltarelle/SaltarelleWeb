// SVGDocument.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGDocument : DocumentBase {
		internal SVGDocument() {
		}

		[IntrinsicProperty]
		public string Domain {
			get { return null; }
		}

		[IntrinsicProperty]
		public SVGElement RootElement {
			get { return default(SVGElement); }
		}
	}
}
