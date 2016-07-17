using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.Geolocation;
using Bridge.Html5.IO;
using Bridge.Html5.Mobile;
using Bridge.Html5.Net;
using System;

namespace Bridge.Html5
{
	[Namespace(false), External, Name("navigator")]
	public static partial class Navigator
	{
		public static readonly string AppCodeName;

		public static readonly string AppName;

		public static readonly string AppVersion;

		public static readonly BatteryManager Battery;

		public static readonly string BuildID;

		public static readonly bool CookieEnabled;

		public static readonly string DoNotTrack;

		public static readonly GeolocationService Geolocation;

		public static extern bool JavaEnabled();

		public static readonly string Language;

		public static readonly int MaxTouchPoints;

		public static readonly MimeTypeArray MimeTypes;

		public static readonly bool OnLine;

		public static readonly string Oscpu;

		public static readonly string Platform;

		public static readonly PluginArray Plugins;

		public static readonly string Product;

		public static readonly string ProductSub;

		public static extern void RegisterContentHandler(string mimeType, string url, string title);

		public static extern void RegisterProtocolHandler(string scheme, string url, string title);

		public static extern bool SendBeacon(string url);

		public static extern bool SendBeacon(string url, TypeOption<ArrayBufferView, Blob, string, FormData> data);

		public static extern bool TaintEnabled();

		public static readonly string UserAgent;

		public static readonly string Vendor;

		public static readonly string VendorSub;

		public static extern bool Vibrate(int duration);

		public static extern bool Vibrate(int[] pattern);
	}
}
