namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CSSPrimitiveValue : CSSValue
	{
		internal CSSPrimitiveValue()
		{
		}

		[Name("CSS_ATTR")]
		public const ushort CSS_ATTR = 22;

		[Name("CSS_CM")]
		public const ushort CSS_CM = 6;

		[Name("CSS_COUNTER")]
		public const ushort CSS_COUNTER = 23;

		[Name("CSS_DEG")]
		public const ushort CSS_DEG = 11;

		[Name("CSS_DIMENSION")]
		public const ushort CSS_DIMENSION = 18;

		[Name("CSS_EMS")]
		public const ushort CSS_EMS = 3;

		[Name("CSS_EXS")]
		public const ushort CSS_EXS = 4;

		[Name("CSS_GRAD")]
		public const ushort CSS_GRAD = 13;

		[Name("CSS_HZ")]
		public const ushort CSS_HZ = 16;

		[Name("CSS_IDENT")]
		public const ushort CSS_IDENT = 21;

		[Name("CSS_IN")]
		public const ushort CSS_IN = 8;

		[Name("CSS_KHZ")]
		public const ushort CSS_KHZ = 17;

		[Name("CSS_MM")]
		public const ushort CSS_MM = 7;

		[Name("CSS_MS")]
		public const ushort CSS_MS = 14;

		[Name("CSS_NUMBER")]
		public const ushort CSS_NUMBER = 1;

		[Name("CSS_PC")]
		public const ushort CSS_PC = 10;

		[Name("CSS_PERCENTAGE")]
		public const ushort CSS_PERCENTAGE = 2;

		[Name("CSS_PT")]
		public const ushort CSS_PT = 9;

		[Name("CSS_PX")]
		public const ushort CSS_PX = 5;

		[Name("CSS_RAD")]
		public const ushort CSS_RAD = 12;

		[Name("CSS_RECT")]
		public const ushort CSS_RECT = 24;

		[Name("CSS_RGBCOLOR")]
		public const ushort CSS_RGBCOLOR = 25;

		[Name("CSS_S")]
		public const ushort CSS_S = 15;

		[Name("CSS_STRING")]
		public const ushort CSS_STRING = 19;

		[Name("CSS_UNKNOWN")]
		public const ushort CSS_UNKNOWN = 0;

		[Name("CSS_URI")]
		public const ushort CSS_URI = 20;

		public Counter GetCounterValue()
		{
			return default(Counter);
		}

		public double GetFloatValue(ushort unitType)
		{
			return 0;
		}

		public Rect GetRectValue()
		{
			return default(Rect);
		}

		public RGBColor GetRGBColorValue()
		{
			return default(RGBColor);
		}

		public string GetStringValue()
		{
			return null;
		}

		[FieldProperty]
		public ushort PrimitiveType
		{
			get {
				return 0;
			}
		}

		public void SetFloatValue(ushort unitType, double floatValue)
		{
		}

		public void SetStringValue(ushort stringType, string stringValue)
		{
		}
	}
}
