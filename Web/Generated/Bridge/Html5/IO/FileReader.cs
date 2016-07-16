namespace Bridge.Html5.IO
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class FileReader : EventTarget
	{
		public FileReader()
		{
		}

		public void Abort()
		{
		}

		public void AddEventListener(FileReaderEvents type, Action listener)
		{
		}

		public void AddEventListener(FileReaderEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(FileReaderEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(FileReaderEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(FileReaderEvents type, HtmlEventHandlerWithTarget<FileReader> listener)
		{
		}

		public void AddEventListener(FileReaderEvents type, HtmlEventHandlerWithTarget<FileReader> listener, bool capture)
		{
		}

		public void AddEventListener(FileReaderEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(FileReaderEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<FileReader> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<FileReader> listener, bool capture)
		{
		}

		public const ushort DONE = 2;

		public const ushort EMPTY = 0;

		[FieldProperty]
		public DOMError Error
		{
			get {
				return default(DOMError);
			}
		}

		public const ushort LOADING = 1;

		[FieldProperty, Name("onabort")]
		public HtmlEventHandler OnAbort
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onerror")]
		public HtmlEventHandler OnError
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onload")]
		public HtmlEventHandler OnLoad
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadend")]
		public HtmlEventHandler OnLoadend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadstart")]
		public HtmlEventHandler OnLoadstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onprogress")]
		public HtmlEventHandler OnProgress
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void ReadAsArrayBuffer(Blob blob)
		{
		}

		public void ReadAsBinaryString(Blob filedata)
		{
		}

		public void ReadAsDataURL(Blob blob)
		{
		}

		public void ReadAsText(Blob blob)
		{
		}

		public void ReadAsText(Blob blob, string label)
		{
		}

		[FieldProperty]
		public ushort ReadyState
		{
			get {
				return 0;
			}
		}

		public void RemoveEventListener(FileReaderEvents type, Action listener)
		{
		}

		public void RemoveEventListener(FileReaderEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(FileReaderEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(FileReaderEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(FileReaderEvents type, HtmlEventHandlerWithTarget<FileReader> listener)
		{
		}

		public void RemoveEventListener(FileReaderEvents type, HtmlEventHandlerWithTarget<FileReader> listener, bool capture)
		{
		}

		public void RemoveEventListener(FileReaderEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(FileReaderEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FileReader> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FileReader> listener, bool capture)
		{
		}

		[FieldProperty]
		public object Result
		{
			get {
				return null;
			}
		}
	}
}
