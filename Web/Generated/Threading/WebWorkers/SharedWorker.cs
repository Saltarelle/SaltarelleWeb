using System.Html;
using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SharedWorker : EventTarget {
		internal SharedWorker() {
		}

		public SharedWorker(string scriptURL) {
		}

		public SharedWorker(string scriptURL, string name) {
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty]
		public MessagePort Port {
			get { return default(MessagePort); }
		}
	}
}
