using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBOpenDBRequest")]
	public partial class OpenDBRequest : Request {
		internal OpenDBRequest() {
		}

		[IntrinsicProperty, ScriptName("onblocked")]
		public HtmlEventHandler OnBlocked {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onupgradeneeded")]
		public HtmlEventHandler OnUpgradeneeded {
			get { return default(HtmlEventHandler); }
			set { }
		}
	}
}
