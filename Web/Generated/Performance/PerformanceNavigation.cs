using System.Runtime.CompilerServices;

namespace System.Performance {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class PerformanceNavigation {
		internal PerformanceNavigation() {
		}

		[IntrinsicProperty]
		public ushort RedirectCount {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ushort Type {
			get {
				return 0;
			}
		}

		[ScriptName("TYPE_BACK_FORWARD")]
		public const ushort TYPE_BACK_FORWARD = 2;

		[ScriptName("TYPE_NAVIGATE")]
		public const ushort TYPE_NAVIGATE = 0;

		[ScriptName("TYPE_RELOAD")]
		public const ushort TYPE_RELOAD = 1;

		[ScriptName("TYPE_RESERVED")]
		public const ushort TYPE_RESERVED = 255;
	}
}
