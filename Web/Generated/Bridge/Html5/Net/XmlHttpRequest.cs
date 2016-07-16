using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.IO;
using Bridge.Html5.Xml;

namespace Bridge.Html5.Net
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("XMLHttpRequest")]
	public partial class XmlHttpRequest : XmlHttpRequestEventTarget
	{
		public extern void Abort();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener, bool capture);

		public extern void AddEventListener(XmlHttpRequestEvents type, Action listener);

		public extern void AddEventListener(XmlHttpRequestEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlHttpRequestEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlHttpRequestEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlHttpRequestEvents type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener);

		public extern void AddEventListener(XmlHttpRequestEvents type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener, bool capture);

		public extern void AddEventListener(XmlHttpRequestEvents type, IEventListener listener);

		public extern void AddEventListener(XmlHttpRequestEvents type, IEventListener listener, bool capture);

		public const ushort DONE = 4;

		public extern string GetAllResponseHeaders();

		public extern string GetResponseHeader(string header);

		[Name("HEADERS_RECEIVED")]
		public const ushort HEADERS_RECEIVED = 2;

		public const ushort LOADING = 3;

		[FieldProperty, Name("onreadystatechange")]
		public extern HtmlEventHandler OnReadyStateChange
		{
			get;
			set;
		}

		public extern void Open(string method, string url);

		public extern void Open(string method, string url, bool async);

		public extern void Open(string method, string url, bool async, string user);

		public extern void Open(string method, string url, bool async, string user, string password);

		public const ushort OPENED = 1;

		public extern void OverrideMimeType(string mime);

		[FieldProperty]
		public extern ReadyState ReadyState
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener, bool capture);

		public extern void RemoveEventListener(XmlHttpRequestEvents type, Action listener);

		public extern void RemoveEventListener(XmlHttpRequestEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlHttpRequestEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlHttpRequestEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlHttpRequestEvents type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener);

		public extern void RemoveEventListener(XmlHttpRequestEvents type, HtmlEventHandlerWithTarget<XmlHttpRequest> listener, bool capture);

		public extern void RemoveEventListener(XmlHttpRequestEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlHttpRequestEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern object Response
		{
			get;
		}

		[FieldProperty]
		public extern string ResponseText
		{
			get;
		}

		[FieldProperty]
		public extern XmlHttpRequestResponseType ResponseType
		{
			get;
			set;
		}

		[FieldProperty]
		public extern DocumentBase ResponseXML
		{
			get;
		}

		public extern void Send();

		public extern void Send(ArrayBuffer data);

		public extern void Send(ArrayBufferView data);

		public extern void Send(Blob data);

		public extern void Send(DocumentBase data);

		public extern void Send(FormData data);

		public extern void Send(string data);

		public extern void SendAsBinary(string body);

		public extern void SetRequestHeader(string header, string value);

		[FieldProperty]
		public extern ushort Status
		{
			get;
		}

		[FieldProperty]
		public extern string StatusText
		{
			get;
		}

		[FieldProperty]
		public extern int Timeout
		{
			get;
			set;
		}

		public const ushort UNSENT = 0;

		[FieldProperty]
		public extern XmlHttpRequestUpload Upload
		{
			get;
		}

		[FieldProperty]
		public extern bool WithCredentials
		{
			get;
			set;
		}
	}
}
