using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class History {
		internal History() {
		}

		public void Back() {
		}

		public void Forward() {
		}

		public void Go(int integerDelta) {
		}

		[IntrinsicProperty]
		public int Length {
			get {
				return 0;
			}
		}

		public void PushState(object data, string title) {
		}

		public void PushState(object data, string title, string url) {
		}

		public void ReplaceState(object data, string title) {
		}

		public void ReplaceState(object data, string title, string url) {
		}

		[IntrinsicProperty]
		public object State {
			get {
				return null;
			}
		}
	}
}
