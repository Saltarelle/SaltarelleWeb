namespace Bridge.Html5.IO
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class FileReader : EventTarget
	{
		public extern FileReader();

		public extern void Abort();

		public extern void AddEventListener(FileReaderEvents type, Action listener);

		public extern void AddEventListener(FileReaderEvents type, Action listener, bool capture);

		public extern void AddEventListener(FileReaderEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(FileReaderEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(FileReaderEvents type, HtmlEventHandlerWithTarget<FileReader> listener);

		public extern void AddEventListener(FileReaderEvents type, HtmlEventHandlerWithTarget<FileReader> listener, bool capture);

		public extern void AddEventListener(FileReaderEvents type, IEventListener listener);

		public extern void AddEventListener(FileReaderEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FileReader> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FileReader> listener, bool capture);

		public const ushort DONE = 2;

		public const ushort EMPTY = 0;

		[FieldProperty]
		public extern DOMError Error
		{
			get;
		}

		public const ushort LOADING = 1;

		[FieldProperty, Name("onabort")]
		public extern HtmlEventHandler OnAbort
		{
			get;
			set;
		}

		[FieldProperty, Name("onerror")]
		public extern HtmlEventHandler OnError
		{
			get;
			set;
		}

		[FieldProperty, Name("onload")]
		public extern HtmlEventHandler OnLoad
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadend")]
		public extern HtmlEventHandler OnLoadend
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadstart")]
		public extern HtmlEventHandler OnLoadstart
		{
			get;
			set;
		}

		[FieldProperty, Name("onprogress")]
		public extern HtmlEventHandler OnProgress
		{
			get;
			set;
		}

		public extern void ReadAsArrayBuffer(Blob blob);

		public extern void ReadAsBinaryString(Blob filedata);

		public extern void ReadAsDataURL(Blob blob);

		public extern void ReadAsText(Blob blob);

		public extern void ReadAsText(Blob blob, string label);

		[FieldProperty]
		public extern ushort ReadyState
		{
			get;
		}

		public extern void RemoveEventListener(FileReaderEvents type, Action listener);

		public extern void RemoveEventListener(FileReaderEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(FileReaderEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(FileReaderEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(FileReaderEvents type, HtmlEventHandlerWithTarget<FileReader> listener);

		public extern void RemoveEventListener(FileReaderEvents type, HtmlEventHandlerWithTarget<FileReader> listener, bool capture);

		public extern void RemoveEventListener(FileReaderEvents type, IEventListener listener);

		public extern void RemoveEventListener(FileReaderEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FileReader> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FileReader> listener, bool capture);

		[FieldProperty]
		public extern object Result
		{
			get;
		}
	}
}
