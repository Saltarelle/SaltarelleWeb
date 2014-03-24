using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CSSPrimitiveValue : CSSValue {
		internal CSSPrimitiveValue() {
		}

		[ScriptName("CSS_ATTR")]
		public const ushort CSS_ATTR = 22;

		[ScriptName("CSS_CM")]
		public const ushort CSS_CM = 6;

		[ScriptName("CSS_COUNTER")]
		public const ushort CSS_COUNTER = 23;

		[ScriptName("CSS_DEG")]
		public const ushort CSS_DEG = 11;

		[ScriptName("CSS_DIMENSION")]
		public const ushort CSS_DIMENSION = 18;

		[ScriptName("CSS_EMS")]
		public const ushort CSS_EMS = 3;

		[ScriptName("CSS_EXS")]
		public const ushort CSS_EXS = 4;

		[ScriptName("CSS_GRAD")]
		public const ushort CSS_GRAD = 13;

		[ScriptName("CSS_HZ")]
		public const ushort CSS_HZ = 16;

		[ScriptName("CSS_IDENT")]
		public const ushort CSS_IDENT = 21;

		[ScriptName("CSS_IN")]
		public const ushort CSS_IN = 8;

		[ScriptName("CSS_KHZ")]
		public const ushort CSS_KHZ = 17;

		[ScriptName("CSS_MM")]
		public const ushort CSS_MM = 7;

		[ScriptName("CSS_MS")]
		public const ushort CSS_MS = 14;

		[ScriptName("CSS_NUMBER")]
		public const ushort CSS_NUMBER = 1;

		[ScriptName("CSS_PC")]
		public const ushort CSS_PC = 10;

		[ScriptName("CSS_PERCENTAGE")]
		public const ushort CSS_PERCENTAGE = 2;

		[ScriptName("CSS_PT")]
		public const ushort CSS_PT = 9;

		[ScriptName("CSS_PX")]
		public const ushort CSS_PX = 5;

		[ScriptName("CSS_RAD")]
		public const ushort CSS_RAD = 12;

		[ScriptName("CSS_RECT")]
		public const ushort CSS_RECT = 24;

		[ScriptName("CSS_RGBCOLOR")]
		public const ushort CSS_RGBCOLOR = 25;

		[ScriptName("CSS_S")]
		public const ushort CSS_S = 15;

		[ScriptName("CSS_STRING")]
		public const ushort CSS_STRING = 19;

		[ScriptName("CSS_UNKNOWN")]
		public const ushort CSS_UNKNOWN = 0;

		[ScriptName("CSS_URI")]
		public const ushort CSS_URI = 20;

		public Counter GetCounterValue() {
			return default(Counter);
		}

		public double GetFloatValue(ushort unitType) {
			return 0;
		}

		public Rect GetRectValue() {
			return default(Rect);
		}

		public RGBColor GetRGBColorValue() {
			return default(RGBColor);
		}

		public string GetStringValue() {
			return null;
		}

		[IntrinsicProperty]
		public ushort PrimitiveType {
			get {
				return 0;
			}
		}

		public void SetFloatValue(ushort unitType, double floatValue) {
		}

		public void SetStringValue(ushort stringType, string stringValue) {
		}
	}
}
