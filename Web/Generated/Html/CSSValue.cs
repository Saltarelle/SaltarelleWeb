using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CSSValue {
		internal CSSValue() {
		}

		[ScriptName("CSS_CUSTOM")]
		public const ushort CSS_CUSTOM = 3;

		[ScriptName("CSS_INHERIT")]
		public const ushort CSS_INHERIT = 0;

		[ScriptName("CSS_PRIMITIVE_VALUE")]
		public const ushort CSS_PRIMITIVE_VALUE = 1;

		[ScriptName("CSS_VALUE_LIST")]
		public const ushort CSS_VALUE_LIST = 2;

		[IntrinsicProperty]
		public string CssText {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public ushort CssValueType {
			get { return 0; }
		}
	}
}
