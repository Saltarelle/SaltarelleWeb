using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.Geolocation;
using Bridge.Html5.IO;
using Bridge.Html5.Mobile;
using Bridge.Html5.Net;
using System;

namespace Bridge.Html5
{
	[Namespace("false"), External, Name("navigator")]
	public static partial class Navigator
	{
		[FieldProperty]
		public static string AppCodeName
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static string AppName
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static string AppVersion
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static BatteryManager Battery
		{
			get {
				return default(BatteryManager);
			}
		}

		[FieldProperty]
		public static string BuildID
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static bool CookieEnabled
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public static string DoNotTrack
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static GeolocationService Geolocation
		{
			get {
				return default(GeolocationService);
			}
		}

		public static bool JavaEnabled()
		{
			return false;
		}

		[FieldProperty]
		public static string Language
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static int MaxTouchPoints
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public static MimeTypeArray MimeTypes
		{
			get {
				return default(MimeTypeArray);
			}
		}

		[FieldProperty]
		public static bool OnLine
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public static string Oscpu
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static string Platform
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static PluginArray Plugins
		{
			get {
				return default(PluginArray);
			}
		}

		[FieldProperty]
		public static string Product
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static string ProductSub
		{
			get {
				return null;
			}
		}

		public static void RegisterContentHandler(string mimeType, string url, string title)
		{
		}

		public static void RegisterProtocolHandler(string scheme, string url, string title)
		{
		}

		public static bool SendBeacon(string url)
		{
			return false;
		}

		public static bool SendBeacon(string url, TypeOption<ArrayBufferView, Blob, string, FormData> data)
		{
			return false;
		}

		public static bool TaintEnabled()
		{
			return false;
		}

		[FieldProperty]
		public static string UserAgent
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static string Vendor
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static string VendorSub
		{
			get {
				return null;
			}
		}

		public static bool Vibrate(int duration)
		{
			return false;
		}

		public static bool Vibrate(int[] pattern)
		{
			return false;
		}
	}
}
