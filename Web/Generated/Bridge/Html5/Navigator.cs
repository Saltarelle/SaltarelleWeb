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
		public static extern string AppCodeName
		{
			get;
		}

		[FieldProperty]
		public static extern string AppName
		{
			get;
		}

		[FieldProperty]
		public static extern string AppVersion
		{
			get;
		}

		[FieldProperty]
		public static extern BatteryManager Battery
		{
			get;
		}

		[FieldProperty]
		public static extern string BuildID
		{
			get;
		}

		[FieldProperty]
		public static extern bool CookieEnabled
		{
			get;
		}

		[FieldProperty]
		public static extern string DoNotTrack
		{
			get;
		}

		[FieldProperty]
		public static extern GeolocationService Geolocation
		{
			get;
		}

		public static extern bool JavaEnabled();

		[FieldProperty]
		public static extern string Language
		{
			get;
		}

		[FieldProperty]
		public static extern int MaxTouchPoints
		{
			get;
		}

		[FieldProperty]
		public static extern MimeTypeArray MimeTypes
		{
			get;
		}

		[FieldProperty]
		public static extern bool OnLine
		{
			get;
		}

		[FieldProperty]
		public static extern string Oscpu
		{
			get;
		}

		[FieldProperty]
		public static extern string Platform
		{
			get;
		}

		[FieldProperty]
		public static extern PluginArray Plugins
		{
			get;
		}

		[FieldProperty]
		public static extern string Product
		{
			get;
		}

		[FieldProperty]
		public static extern string ProductSub
		{
			get;
		}

		public static extern void RegisterContentHandler(string mimeType, string url, string title);

		public static extern void RegisterProtocolHandler(string scheme, string url, string title);

		public static extern bool SendBeacon(string url);

		public static extern bool SendBeacon(string url, TypeOption<ArrayBufferView, Blob, string, FormData> data);

		public static extern bool TaintEnabled();

		[FieldProperty]
		public static extern string UserAgent
		{
			get;
		}

		[FieldProperty]
		public static extern string Vendor
		{
			get;
		}

		[FieldProperty]
		public static extern string VendorSub
		{
			get;
		}

		public static extern bool Vibrate(int duration);

		public static extern bool Vibrate(int[] pattern);
	}
}
