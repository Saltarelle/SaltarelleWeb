using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class Screen : EventTarget {
		internal Screen() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<Screen> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<Screen> listener, bool capture) {
		}

		[IntrinsicProperty]
		public int AvailHeight {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int AvailLeft {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int AvailTop {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int AvailWidth {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int ColorDepth {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int Height {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int Left {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int PixelDepth {
			get {
				return 0;
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Screen> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Screen> listener, bool capture) {
		}

		[IntrinsicProperty]
		public int Top {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int Width {
			get {
				return 0;
			}
		}
	}
}
