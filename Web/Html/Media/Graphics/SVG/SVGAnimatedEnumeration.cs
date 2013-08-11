using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGAnimatedEnumeration<TEnumeration> where TEnumeration : struct {
		private SVGAnimatedEnumeration() {
		}

		[IntrinsicProperty]
		public TEnumeration AnimVal {
			get { return default(TEnumeration); }
		}

		[IntrinsicProperty]
		public TEnumeration BaseVal {
			get { return default(TEnumeration); }
			set { }
		}
	}
}
