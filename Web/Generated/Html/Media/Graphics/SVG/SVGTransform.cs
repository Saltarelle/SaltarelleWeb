using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGTransform {
		internal SVGTransform() {
		}

		[IntrinsicProperty]
		public float Angle {
			get { return 0; }
		}

		[IntrinsicProperty]
		public SVGMatrix Matrix {
			get { return default(SVGMatrix); }
		}

		public void SetMatrix(SVGMatrix matrix) {
		}

		public void SetRotate(float angle, float cx, float cy) {
		}

		public void SetScale(float sx, float sy) {
		}

		public void SetSkewX(float angle) {
		}

		public void SetSkewY(float angle) {
		}

		public void SetTranslate(float tx, float ty) {
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
			get { return default(SVGTransformType); }
		}
	}
}
