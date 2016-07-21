using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.Elements;
using Bridge.Html5.IO;

namespace Bridge.Html5.Net
{
	[Namespace(false), External, Name("XMLHttpRequest")]
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

		[Name("onreadystatechange")]
		public HtmlEventHandler OnReadyStateChange;

		public extern void Open(string method, string url);

		public extern void Open(string method, string url, bool async);

		public extern void Open(string method, string url, bool async, string user);

		public extern void Open(string method, string url, bool async, string user, string password);

		public const ushort OPENED = 1;

		public extern void OverrideMimeType(string mime);

		public readonly ReadyState ReadyState;

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

		public readonly object Response;

		public readonly string ResponseText;

		public XmlHttpRequestResponseType ResponseType;

		public readonly DocumentBase ResponseXML;

		public extern void Send();

		public extern void Send(ArrayBuffer data);

		public extern void Send(ArrayBufferView data);

		public extern void Send(Blob data);

		public extern void Send(DocumentBase data);

		public extern void Send(FormData data);

		public extern void Send(string data);

		public extern void SendAsBinary(string body);

		public extern void SetRequestHeader(string header, string value);

		public readonly ushort Status;

		public readonly string StatusText;

		public int Timeout;

		public const ushort UNSENT = 0;

		public readonly XmlHttpRequestUpload Upload;

		public bool WithCredentials;
	}
}
