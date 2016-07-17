namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGTransform
	{
		internal extern SVGTransform();

		public readonly double Angle;

		public readonly SVGMatrix Matrix;

		public extern void SetMatrix(SVGMatrix matrix);

		public extern void SetRotate(double angle, double cx, double cy);

		public extern void SetScale(double sx, double sy);

		public extern void SetSkewX(double angle);

		public extern void SetSkewY(double angle);

		public extern void SetTranslate(double tx, double ty);

		[Name("SVG_TRANSFORM_MATRIX")]
		public const ushort SVG_TRANSFORM_MATRIX = 1;

		[Name("SVG_TRANSFORM_ROTATE")]
		public const ushort SVG_TRANSFORM_ROTATE = 4;

		[Name("SVG_TRANSFORM_SCALE")]
		public const ushort SVG_TRANSFORM_SCALE = 3;

		[Name("SVG_TRANSFORM_SKEWX")]
		public const ushort SVG_TRANSFORM_SKEWX = 5;

		[Name("SVG_TRANSFORM_SKEWY")]
		public const ushort SVG_TRANSFORM_SKEWY = 6;

		[Name("SVG_TRANSFORM_TRANSLATE")]
		public const ushort SVG_TRANSFORM_TRANSLATE = 2;

		[Name("SVG_TRANSFORM_UNKNOWN")]
		public const ushort SVG_TRANSFORM_UNKNOWN = 0;

		public readonly SVGTransformType Type;
	}
}
