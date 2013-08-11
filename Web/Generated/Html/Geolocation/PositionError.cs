using System.Runtime.CompilerServices;

namespace System.Html.Geolocation {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Object")]
	public partial class PositionError {
		internal PositionError() {
		}

		[IntrinsicProperty]
		public ushort Code {
			get { return 0; }
		}

		[IntrinsicProperty]
		public string Message {
			get { return null; }
		}

		[IntrinsicProperty, ScriptName("PERMISSION_DENIED")]
		public ushort PERMISSION_DENIED {
			get { return 0; }
		}

		[IntrinsicProperty, ScriptName("POSITION_UNAVAILABLE")]
		public ushort POSITION_UNAVAILABLE {
			get { return 0; }
		}

		[IntrinsicProperty]
		public ushort TIMEOUT {
			get { return 0; }
		}
	}
}
