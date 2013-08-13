using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGTextPathElement : SVGTextContentElement {
		internal SVGTextPathElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedString Href {
			get {
				return default(SVGAnimatedString);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGTextPathMethod> Method {
			get {
				return default(SVGAnimatedEnumeration<SVGTextPathMethod>);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGTextPathSpacing> Spacing {
			get {
				return default(SVGAnimatedEnumeration<SVGTextPathSpacing>);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedLength StartOffset {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[ScriptName("TEXTPATH_METHODTYPE_ALIGN")]
		public const ushort TEXTPATH_METHODTYPE_ALIGN = 1;

		[ScriptName("TEXTPATH_METHODTYPE_STRETCH")]
		public const ushort TEXTPATH_METHODTYPE_STRETCH = 2;

		[ScriptName("TEXTPATH_METHODTYPE_UNKNOWN")]
		public const ushort TEXTPATH_METHODTYPE_UNKNOWN = 0;

		[ScriptName("TEXTPATH_SPACINGTYPE_AUTO")]
		public const ushort TEXTPATH_SPACINGTYPE_AUTO = 1;

		[ScriptName("TEXTPATH_SPACINGTYPE_EXACT")]
		public const ushort TEXTPATH_SPACINGTYPE_EXACT = 2;

		[ScriptName("TEXTPATH_SPACINGTYPE_UNKNOWN")]
		public const ushort TEXTPATH_SPACINGTYPE_UNKNOWN = 0;
	}
}
