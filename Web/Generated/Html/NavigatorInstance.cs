using System.Html.Geolocation;
using System.Html.Mobile;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Navigator")]
	public partial class NavigatorInstance {
		internal NavigatorInstance() {
		}

		[IntrinsicProperty]
		public string AppCodeName {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string AppName {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string AppVersion {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public BatteryManager Battery {
			get {
				return default(BatteryManager);
			}
		}

		[IntrinsicProperty]
		public string BuildID {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public bool CookieEnabled {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public string DoNotTrack {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public GeolocationService Geolocation {
			get {
				return default(GeolocationService);
			}
		}

		public bool JavaEnabled() {
			return false;
		}

		[IntrinsicProperty]
		public string Language {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public MimeTypeArray MimeTypes {
			get {
				return default(MimeTypeArray);
			}
		}

		[IntrinsicProperty]
		public bool OnLine {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public string Oscpu {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string Platform {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public PluginArray Plugins {
			get {
				return default(PluginArray);
			}
		}

		[IntrinsicProperty]
		public string Product {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string ProductSub {
			get {
				return null;
			}
		}

		public void RegisterContentHandler(string mimeType, string url, string title) {
		}

		public void RegisterProtocolHandler(string scheme, string url, string title) {
		}

		public bool TaintEnabled() {
			return false;
		}

		[IntrinsicProperty]
		public string UserAgent {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string Vendor {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string VendorSub {
			get {
				return null;
			}
		}

		public bool Vibrate(uint duration) {
			return false;
		}

		public bool Vibrate(uint[] pattern) {
			return false;
		}
	}
}
