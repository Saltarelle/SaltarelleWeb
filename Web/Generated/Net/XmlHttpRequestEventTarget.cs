using System.Html;
using System.Runtime.CompilerServices;

namespace System.Net {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("EventTarget")]
	public partial class XmlHttpRequestEventTarget : EventTarget {
		internal XmlHttpRequestEventTarget() {
		}

		[IntrinsicProperty, ScriptName("onabort")]
		public HtmlEventHandler OnAbort {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onload")]
		public HtmlEventHandler OnLoad {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onloadend")]
		public HtmlEventHandler OnLoadend {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onloadstart")]
		public HtmlEventHandler OnLoadstart {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onprogress")]
		public HtmlEventHandler OnProgress {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("ontimeout")]
		public HtmlEventHandler OnTimeout {
			get { return default(HtmlEventHandler); }
			set { }
		}
	}
}
