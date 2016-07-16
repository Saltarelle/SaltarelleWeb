using System.Runtime.CompilerServices;

namespace System.Html.Geolocation {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Object")]
	public partial class Position {
		internal Position() {
		}

		[IntrinsicProperty]
		public Coordinates Coords {
			get {
				return default(Coordinates);
			}
		}

		[IntrinsicProperty]
		public long Timestamp {
			get {
				return 0;
			}
		}
	}
}
