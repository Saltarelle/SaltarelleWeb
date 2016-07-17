namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGAngle
	{
		internal extern SVGAngle();

		public extern void ConvertToSpecifiedUnits(SVGAngleUnitType unitType);

		public extern void NewValueSpecifiedUnits(SVGAngleUnitType unitType, double valueInSpecifiedUnits);

		[Name("SVG_ANGLETYPE_DEG")]
		public const ushort SVG_ANGLETYPE_DEG = 2;

		[Name("SVG_ANGLETYPE_GRAD")]
		public const ushort SVG_ANGLETYPE_GRAD = 4;

		[Name("SVG_ANGLETYPE_RAD")]
		public const ushort SVG_ANGLETYPE_RAD = 3;

		[Name("SVG_ANGLETYPE_UNKNOWN")]
		public const ushort SVG_ANGLETYPE_UNKNOWN = 0;

		[Name("SVG_ANGLETYPE_UNSPECIFIED")]
		public const ushort SVG_ANGLETYPE_UNSPECIFIED = 1;

		public readonly SVGAngleUnitType UnitType;

		public double Value;

		public string ValueAsString;

		public double ValueInSpecifiedUnits;
	}
}
