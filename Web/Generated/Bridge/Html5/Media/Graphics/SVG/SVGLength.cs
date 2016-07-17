namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGLength
	{
		internal extern SVGLength();

		public extern void ConvertToSpecifiedUnits(SVGLengthType unitType);

		public extern void NewValueSpecifiedUnits(SVGLengthType unitType, double valueInSpecifiedUnits);

		[Name("SVG_LENGTHTYPE_CM")]
		public const ushort SVG_LENGTHTYPE_CM = 6;

		[Name("SVG_LENGTHTYPE_EMS")]
		public const ushort SVG_LENGTHTYPE_EMS = 3;

		[Name("SVG_LENGTHTYPE_EXS")]
		public const ushort SVG_LENGTHTYPE_EXS = 4;

		[Name("SVG_LENGTHTYPE_IN")]
		public const ushort SVG_LENGTHTYPE_IN = 8;

		[Name("SVG_LENGTHTYPE_MM")]
		public const ushort SVG_LENGTHTYPE_MM = 7;

		[Name("SVG_LENGTHTYPE_NUMBER")]
		public const ushort SVG_LENGTHTYPE_NUMBER = 1;

		[Name("SVG_LENGTHTYPE_PC")]
		public const ushort SVG_LENGTHTYPE_PC = 10;

		[Name("SVG_LENGTHTYPE_PERCENTAGE")]
		public const ushort SVG_LENGTHTYPE_PERCENTAGE = 2;

		[Name("SVG_LENGTHTYPE_PT")]
		public const ushort SVG_LENGTHTYPE_PT = 9;

		[Name("SVG_LENGTHTYPE_PX")]
		public const ushort SVG_LENGTHTYPE_PX = 5;

		[Name("SVG_LENGTHTYPE_UNKNOWN")]
		public const ushort SVG_LENGTHTYPE_UNKNOWN = 0;

		public readonly SVGLengthType UnitType;

		public double Value;

		public string ValueAsString;

		public double ValueInSpecifiedUnits;
	}
}
