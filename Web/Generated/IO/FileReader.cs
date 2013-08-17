using System.Html;
using System.Runtime.CompilerServices;

namespace System.IO {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class FileReader : EventTarget {
		public FileReader() {
		}

		public void Abort() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<FileReader> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<FileReader> listener, bool capture) {
		}

		public const ushort DONE = 2;

		public const ushort EMPTY = 0;

		[IntrinsicProperty]
		public DOMError Error {
			get {
				return default(DOMError);
			}
		}

		public const ushort LOADING = 1;

		[IntrinsicProperty, ScriptName("onabort")]
		public HtmlEventHandler OnAbort {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onload")]
		public HtmlEventHandler OnLoad {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadend")]
		public HtmlEventHandler OnLoadend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadstart")]
		public HtmlEventHandler OnLoadstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onprogress")]
		public HtmlEventHandler OnProgress {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void ReadAsArrayBuffer(Blob blob) {
		}

		public void ReadAsBinaryString(Blob filedata) {
		}

		public void ReadAsDataURL(Blob blob) {
		}

		public void ReadAsText(Blob blob) {
		}

		public void ReadAsText(Blob blob, string label) {
		}

		[IntrinsicProperty]
		public ushort ReadyState {
			get {
				return 0;
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FileReader> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FileReader> listener, bool capture) {
		}

		[IntrinsicProperty]
		public object Result {
			get {
				return null;
			}
		}
	}
}
