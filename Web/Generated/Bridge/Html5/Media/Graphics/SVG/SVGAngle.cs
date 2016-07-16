namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGAngle
	{
		internal SVGAngle()
		{
		}

		public void ConvertToSpecifiedUnits(SVGAngleUnitType unitType)
		{
		}

		public void NewValueSpecifiedUnits(SVGAngleUnitType unitType, double valueInSpecifiedUnits)
		{
		}

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

		[FieldProperty]
		public SVGAngleUnitType UnitType
		{
			get {
				return default(SVGAngleUnitType);
			}
		}

		[FieldProperty]
		public double Value
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public string ValueAsString
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public double ValueInSpecifiedUnits
		{
			get {
				return 0;
			}
			set {
			}
		}
	}
}
