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
		internal NavigatorInstance()
		{
		}

		[FieldProperty]
		public string AppCodeName
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string AppName
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string AppVersion
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public BatteryManager Battery
		{
			get {
				return default(BatteryManager);
			}
		}

		[FieldProperty]
		public string BuildID
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public bool CookieEnabled
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public string DoNotTrack
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public GeolocationService Geolocation
		{
			get {
				return default(GeolocationService);
			}
		}

		public bool JavaEnabled()
		{
			return false;
		}

		[FieldProperty]
		public string Language
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public int MaxTouchPoints
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public MimeTypeArray MimeTypes
		{
			get {
				return default(MimeTypeArray);
			}
		}

		[FieldProperty]
		public bool OnLine
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public string Oscpu
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string Platform
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public PluginArray Plugins
		{
			get {
				return default(PluginArray);
			}
		}

		[FieldProperty]
		public string Product
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string ProductSub
		{
			get {
				return null;
			}
		}

		public void RegisterContentHandler(string mimeType, string url, string title)
		{
		}

		public void RegisterProtocolHandler(string scheme, string url, string title)
		{
		}

		public bool SendBeacon(string url)
		{
			return false;
		}

		public bool SendBeacon(string url, TypeOption<ArrayBufferView, Blob, string, FormData> data)
		{
			return false;
		}

		public bool TaintEnabled()
		{
			return false;
		}

		[FieldProperty]
		public string UserAgent
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string Vendor
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string VendorSub
		{
			get {
				return null;
			}
		}

		public bool Vibrate(int duration)
		{
			return false;
		}

		public bool Vibrate(int[] pattern)
		{
			return false;
		}
	}
}
