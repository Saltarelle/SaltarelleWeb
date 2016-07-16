using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGTransform {
		internal SVGTransform() {
		}

		[IntrinsicProperty]
		public double Angle {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public SVGMatrix Matrix {
			get {
				return default(SVGMatrix);
			}
		}

		public void SetMatrix(SVGMatrix matrix) {
		}

		public void SetRotate(double angle, double cx, double cy) {
		}

		public void SetScale(double sx, double sy) {
		}

		public void SetSkewX(double angle) {
		}

		public void SetSkewY(double angle) {
		}

		public void SetTranslate(double tx, double ty) {
		}

		[ScriptName("SVG_TRANSFORM_MATRIX")]
		public const ushort SVG_TRANSFORM_MATRIX = 1;

		[ScriptName("SVG_TRANSFORM_ROTATE")]
		public const ushort SVG_TRANSFORM_ROTATE = 4;

		[ScriptName("SVG_TRANSFORM_SCALE")]
		public const ushort SVG_TRANSFORM_SCALE = 3;

		[ScriptName("SVG_TRANSFORM_SKEWX")]
		public const ushort SVG_TRANSFORM_SKEWX = 5;

		[ScriptName("SVG_TRANSFORM_SKEWY")]
		public const ushort SVG_TRANSFORM_SKEWY = 6;

		[ScriptName("SVG_TRANSFORM_TRANSLATE")]
		public const ushort SVG_TRANSFORM_TRANSLATE = 2;

		[ScriptName("SVG_TRANSFORM_UNKNOWN")]
		public const ushort SVG_TRANSFORM_UNKNOWN = 0;

		[IntrinsicProperty]
		public SVGTransformType Type {
			get {
				return default(SVGTransformType);
			}
		}
	}
}
