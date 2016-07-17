using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.Geolocation;
using Bridge.Html5.IO;
using Bridge.Html5.Mobile;
using Bridge.Html5.Net;
using System;

namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Navigator")]
	public partial class NavigatorInstance
	{
		internal extern NavigatorInstance();

		public readonly string AppCodeName;

		public readonly string AppName;

		public readonly string AppVersion;

		public readonly BatteryManager Battery;

		public readonly string BuildID;

		public readonly bool CookieEnabled;

		public readonly string DoNotTrack;

		public readonly GeolocationService Geolocation;

		public extern bool JavaEnabled();

		public readonly string Language;

		public readonly int MaxTouchPoints;

		public readonly MimeTypeArray MimeTypes;

		public readonly bool OnLine;

		public readonly string Oscpu;

		public readonly string Platform;

		public readonly PluginArray Plugins;

		public readonly string Product;

		public readonly string ProductSub;

		public extern void RegisterContentHandler(string mimeType, string url, string title);

		public extern void RegisterProtocolHandler(string scheme, string url, string title);

		public extern bool SendBeacon(string url);

		public extern bool SendBeacon(string url, TypeOption<ArrayBufferView, Blob, string, FormData> data);

		public extern bool TaintEnabled();

		public readonly string UserAgent;

		public readonly string Vendor;

		public readonly string VendorSub;

		public extern bool Vibrate(int duration);

		public extern bool Vibrate(int[] pattern);
	}
}
