using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGLength {
		internal SVGLength() {
		}

		public void ConvertToSpecifiedUnits(SVGLengthType unitType) {
		}

		public void NewValueSpecifiedUnits(SVGLengthType unitType, float valueInSpecifiedUnits) {
		}

		[ScriptName("SVG_LENGTHTYPE_CM")]
		public const ushort SVG_LENGTHTYPE_CM = 6;

		[ScriptName("SVG_LENGTHTYPE_EMS")]
		public const ushort SVG_LENGTHTYPE_EMS = 3;

		[ScriptName("SVG_LENGTHTYPE_EXS")]
		public const ushort SVG_LENGTHTYPE_EXS = 4;

		[ScriptName("SVG_LENGTHTYPE_IN")]
		public const ushort SVG_LENGTHTYPE_IN = 8;

		[ScriptName("SVG_LENGTHTYPE_MM")]
		public const ushort SVG_LENGTHTYPE_MM = 7;

		[ScriptName("SVG_LENGTHTYPE_NUMBER")]
		public const ushort SVG_LENGTHTYPE_NUMBER = 1;

		[ScriptName("SVG_LENGTHTYPE_PC")]
		public const ushort SVG_LENGTHTYPE_PC = 10;

		[ScriptName("SVG_LENGTHTYPE_PERCENTAGE")]
		public const ushort SVG_LENGTHTYPE_PERCENTAGE = 2;

		[ScriptName("SVG_LENGTHTYPE_PT")]
		public const ushort SVG_LENGTHTYPE_PT = 9;

		[ScriptName("SVG_LENGTHTYPE_PX")]
		public const ushort SVG_LENGTHTYPE_PX = 5;

		[ScriptName("SVG_LENGTHTYPE_UNKNOWN")]
		public const ushort SVG_LENGTHTYPE_UNKNOWN = 0;

		[IntrinsicProperty]
		public SVGLengthType UnitType {
			get {
				return default(SVGLengthType);
			}
		}

		[IntrinsicProperty]
		public float Value {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string ValueAsString {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public float ValueInSpecifiedUnits {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
