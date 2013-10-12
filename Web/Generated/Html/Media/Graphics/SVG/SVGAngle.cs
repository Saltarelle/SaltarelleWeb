using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGAngle {
		internal SVGAngle() {
		}

		public void ConvertToSpecifiedUnits(SVGAngleUnitType unitType) {
		}

		public void NewValueSpecifiedUnits(SVGAngleUnitType unitType, float valueInSpecifiedUnits) {
		}

		[ScriptName("SVG_ANGLETYPE_DEG")]
		public const ushort SVG_ANGLETYPE_DEG = 2;

		[ScriptName("SVG_ANGLETYPE_GRAD")]
		public const ushort SVG_ANGLETYPE_GRAD = 4;

		[ScriptName("SVG_ANGLETYPE_RAD")]
		public const ushort SVG_ANGLETYPE_RAD = 3;

		[ScriptName("SVG_ANGLETYPE_UNKNOWN")]
		public const ushort SVG_ANGLETYPE_UNKNOWN = 0;

		[ScriptName("SVG_ANGLETYPE_UNSPECIFIED")]
		public const ushort SVG_ANGLETYPE_UNSPECIFIED = 1;

		[IntrinsicProperty]
		public SVGAngleUnitType UnitType {
			get {
				return default(SVGAngleUnitType);
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
