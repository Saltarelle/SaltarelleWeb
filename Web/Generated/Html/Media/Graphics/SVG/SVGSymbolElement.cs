// SVGSymbolElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGSymbolElement : SVGElement {
		internal SVGSymbolElement() {
		}

		public bool HasExtension(string extension) {
			return false;
		}

		[IntrinsicProperty]
		public SVGAnimatedPreserveAspectRatio PreserveAspectRatio {
			get { return default(SVGAnimatedPreserveAspectRatio); }
		}

		[IntrinsicProperty]
		public SVGStringList RequiredExtensions {
			get { return default(SVGStringList); }
		}

		[IntrinsicProperty]
		public SVGStringList RequiredFeatures {
			get { return default(SVGStringList); }
		}

		[IntrinsicProperty]
		public SVGStringList SystemLanguage {
			get { return default(SVGStringList); }
		}

		[IntrinsicProperty]
		public SVGAnimatedRect ViewBox {
			get { return default(SVGAnimatedRect); }
		}
	}
}
