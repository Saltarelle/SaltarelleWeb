using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.IO;
using Bridge.Html5.Xml;

namespace Bridge.Html5.Net
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("XMLHttpRequest")]
	public partial class XmlHttpRequest : XmlHttpRequestEventTarget
	{
		public void Abort()
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener, bool capture)
		{
		}

		public void AddEventListener(XmlHttpRequestEvents type, Action listener)
		{
		}

		public void AddEventListener(XmlHttpRequestEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(XmlHttpRequestEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(XmlHttpRequestEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(XmlHttpRequestEvents type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener)
		{
		}

		public void AddEventListener(XmlHttpRequestEvents type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener, bool capture)
		{
		}

		public void AddEventListener(XmlHttpRequestEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(XmlHttpRequestEvents type, IEventListener listener, bool capture)
		{
		}

		public const ushort DONE = 4;

		public string GetAllResponseHeaders()
		{
			return null;
		}

		public string GetResponseHeader(string header)
		{
			return null;
		}

		[Name("HEADERS_RECEIVED")]
		public const ushort HEADERS_RECEIVED = 2;

		public const ushort LOADING = 3;

		[FieldProperty, Name("onreadystatechange")]
		public HtmlEventHandler OnReadyStateChange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void Open(string method, string url)
		{
		}

		public void Open(string method, string url, bool async)
		{
		}

		public void Open(string method, string url, bool async, string user)
		{
		}

		public void Open(string method, string url, bool async, string user, string password)
		{
		}

		public const ushort OPENED = 1;

		public void OverrideMimeType(string mime)
		{
		}

		[FieldProperty]
		public ReadyState ReadyState
		{
			get {
				return default(ReadyState);
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener, bool capture)
		{
		}

		public void RemoveEventListener(XmlHttpRequestEvents type, Action listener)
		{
		}

		public void RemoveEventListener(XmlHttpRequestEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(XmlHttpRequestEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(XmlHttpRequestEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(XmlHttpRequestEvents type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener)
		{
		}

		public void RemoveEventListener(XmlHttpRequestEvents type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener, bool capture)
		{
		}

		public void RemoveEventListener(XmlHttpRequestEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(XmlHttpRequestEvents type, IEventListener listener, bool capture)
		{
		}

		[FieldProperty]
		public object Response
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string ResponseText
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public XmlHttpRequestResponseType ResponseType
		{
			get {
				return default(XmlHttpRequestResponseType);
			}
			set {
			}
		}

		[FieldProperty]
		public DocumentBase ResponseXML
		{
			get {
				return default(DocumentBase);
			}
		}

		public void Send()
		{
		}

		public void Send(ArrayBuffer data)
		{
		}

		public void Send(ArrayBufferView data)
		{
		}

		public void Send(Blob data)
		{
		}

		public void Send(DocumentBase data)
		{
		}

		public void Send(FormData data)
		{
		}

		public void Send(string data)
		{
		}

		public void SendAsBinary(string body)
		{
		}

		public void SetRequestHeader(string header, string value)
		{
		}

		[FieldProperty]
		public ushort Status
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public string StatusText
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public int Timeout
		{
			get {
				return 0;
			}
			set {
			}
		}

		public const ushort UNSENT = 0;

		[FieldProperty]
		public XmlHttpRequestUpload Upload
		{
			get {
				return default(XmlHttpRequestUpload);
			}
		}

		[FieldProperty]
		public bool WithCredentials
		{
			get {
				return false;
			}
			set {
			}
		}
	}
}
