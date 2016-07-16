namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGTransform
	{
		internal SVGTransform()
		{
		}

		[FieldProperty]
		public double Angle
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public SVGMatrix Matrix
		{
			get {
				return default(SVGMatrix);
			}
		}

		public void SetMatrix(SVGMatrix matrix)
		{
		}

		public void SetRotate(double angle, double cx, double cy)
		{
		}

		public void SetScale(double sx, double sy)
		{
		}

		public void SetSkewX(double angle)
		{
		}

		public void SetSkewY(double angle)
		{
		}

		public void SetTranslate(double tx, double ty)
		{
		}

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

		[FieldProperty]
		public SVGTransformType Type
		{
			get {
				return default(SVGTransformType);
			}
		}
	}
}
