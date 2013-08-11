using System.Runtime.CompilerServices;

namespace System.Html.Geolocation {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Object")]
	public partial class Coordinates {
		internal Coordinates() {
		}

		[IntrinsicProperty]
		public double Accuracy {
			get { return 0; }
		}

		[IntrinsicProperty]
		public double? Altitude {
			get { return null; }
		}

		[IntrinsicProperty]
		public double? AltitudeAccuracy {
			get { return null; }
		}

		[IntrinsicProperty]
		public double? Heading {
			get { return null; }
		}

		[IntrinsicProperty]
		public double Latitude {
			get { return 0; }
		}

		[IntrinsicProperty]
		public double Longitude {
			get { return 0; }
		}

		[IntrinsicProperty]
		public double? Speed {
			get { return null; }
		}
	}
}
