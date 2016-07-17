namespace Bridge.Html5.Net
{
	[Namespace(false), External, Name("XMLHttpRequestUpload")]
	public partial class XmlHttpRequestUpload : XmlHttpRequestEventTarget
	{
		internal extern XmlHttpRequestUpload();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequestUpload> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequestUpload> listener, bool capture);

		public extern void AddEventListener(XmlHttpRequestUploadEvents type, Action listener);

		public extern void AddEventListener(XmlHttpRequestUploadEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlHttpRequestUploadEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlHttpRequestUploadEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlHttpRequestUploadEvents type, HtmlEventHandlerWithTarget<XmlHttpRequestUpload> listener);

		public extern void AddEventListener(XmlHttpRequestUploadEvents type, HtmlEventHandlerWithTarget<XmlHttpRequestUpload> listener, bool capture);

		public extern void AddEventListener(XmlHttpRequestUploadEvents type, IEventListener listener);

		public extern void AddEventListener(XmlHttpRequestUploadEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequestUpload> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequestUpload> listener, bool capture);

		public extern void RemoveEventListener(XmlHttpRequestUploadEvents type, Action listener);

		public extern void RemoveEventListener(XmlHttpRequestUploadEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlHttpRequestUploadEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlHttpRequestUploadEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlHttpRequestUploadEvents type, HtmlEventHandlerWithTarget<XmlHttpRequestUpload> listener);

		public extern void RemoveEventListener(XmlHttpRequestUploadEvents type, HtmlEventHandlerWithTarget<XmlHttpRequestUpload> listener, bool capture);

		public extern void RemoveEventListener(XmlHttpRequestUploadEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlHttpRequestUploadEvents type, IEventListener listener, bool capture);
	}
}
