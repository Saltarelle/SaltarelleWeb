using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.Geolocation;
using Bridge.Html5.IO;
using Bridge.Html5.Mobile;
using Bridge.Html5.Net;
using System;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Navigator")]
	public partial class NavigatorInstance
	{
		internal extern NavigatorInstance();

		[FieldProperty]
		public extern string AppCodeName
		{
			get;
		}

		[FieldProperty]
		public extern string AppName
		{
			get;
		}

		[FieldProperty]
		public extern string AppVersion
		{
			get;
		}

		[FieldProperty]
		public extern BatteryManager Battery
		{
			get;
		}

		[FieldProperty]
		public extern string BuildID
		{
			get;
		}

		[FieldProperty]
		public extern bool CookieEnabled
		{
			get;
		}

		[FieldProperty]
		public extern string DoNotTrack
		{
			get;
		}

		[FieldProperty]
		public extern GeolocationService Geolocation
		{
			get;
		}

		public extern bool JavaEnabled();

		[FieldProperty]
		public extern string Language
		{
			get;
		}

		[FieldProperty]
		public extern int MaxTouchPoints
		{
			get;
		}

		[FieldProperty]
		public extern MimeTypeArray MimeTypes
		{
			get;
		}

		[FieldProperty]
		public extern bool OnLine
		{
			get;
		}

		[FieldProperty]
		public extern string Oscpu
		{
			get;
		}

		[FieldProperty]
		public extern string Platform
		{
			get;
		}

		[FieldProperty]
		public extern PluginArray Plugins
		{
			get;
		}

		[FieldProperty]
		public extern string Product
		{
			get;
		}

		[FieldProperty]
		public extern string ProductSub
		{
			get;
		}

		public extern void RegisterContentHandler(string mimeType, string url, string title);

		public extern void RegisterProtocolHandler(string scheme, string url, string title);

		public extern bool SendBeacon(string url);

		public extern bool SendBeacon(string url, TypeOption<ArrayBufferView, Blob, string, FormData> data);

		public extern bool TaintEnabled();

		[FieldProperty]
		public extern string UserAgent
		{
			get;
		}

		[FieldProperty]
		public extern string Vendor
		{
			get;
		}

		[FieldProperty]
		public extern string VendorSub
		{
			get;
		}

		public extern bool Vibrate(int duration);

		public extern bool Vibrate(int[] pattern);
	}
}
