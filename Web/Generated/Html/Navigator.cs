using System.Html.Geolocation;
using System.Html.Mobile;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported, ScriptName("navigator")]
	public static partial class Navigator {
		[IntrinsicProperty]
		public static string AppCodeName {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static string AppName {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static string AppVersion {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static BatteryManager Battery {
			get {
				return default(BatteryManager);
			}
		}

		[IntrinsicProperty]
		public static string BuildID {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static bool CookieEnabled {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public static string DoNotTrack {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static GeolocationService Geolocation {
			get {
				return default(GeolocationService);
			}
		}

		public static bool JavaEnabled() {
			return false;
		}

		[IntrinsicProperty]
		public static string Language {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static MimeTypeArray MimeTypes {
			get {
				return default(MimeTypeArray);
			}
		}

		[IntrinsicProperty]
		public static bool OnLine {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public static string Oscpu {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static string Platform {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static PluginArray Plugins {
			get {
				return default(PluginArray);
			}
		}

		[IntrinsicProperty]
		public static string Product {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static string ProductSub {
			get {
				return null;
			}
		}

		public static void RegisterContentHandler(string mimeType, string url, string title) {
		}

		public static void RegisterProtocolHandler(string scheme, string url, string title) {
		}

		public static bool TaintEnabled() {
			return false;
		}

		[IntrinsicProperty]
		public static string UserAgent {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static string Vendor {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static string VendorSub {
			get {
				return null;
			}
		}

		public static bool Vibrate(uint duration) {
			return false;
		}

		public static bool Vibrate(uint[] pattern) {
			return false;
		}
	}
}
