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

		public readonly DOMError Error;

		public const ushort LOADING = 1;

		[Name("onabort")]
		public HtmlEventHandler OnAbort;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onload")]
		public HtmlEventHandler OnLoad;

		[Name("onloadend")]
		public HtmlEventHandler OnLoadend;

		[Name("onloadstart")]
		public HtmlEventHandler OnLoadstart;

		[Name("onprogress")]
		public HtmlEventHandler OnProgress;

		public extern void ReadAsArrayBuffer(Blob blob);

		public extern void ReadAsBinaryString(Blob filedata);

		public extern void ReadAsDataURL(Blob blob);

		public extern void ReadAsText(Blob blob);

		public extern void ReadAsText(Blob blob, string label);

		public readonly ushort ReadyState;

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

		public readonly object Result;
	}
}
