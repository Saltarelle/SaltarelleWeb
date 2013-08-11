using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGScriptElement : SVGElement {
		internal SVGScriptElement() {
		}

		[IntrinsicProperty]
		public string CrossOrigin {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public SVGAnimatedString Href {
			get { return default(SVGAnimatedString); }
		}

		[IntrinsicProperty]
		public string Type {
			get { return null; }
			set { }
		}
	}
}
