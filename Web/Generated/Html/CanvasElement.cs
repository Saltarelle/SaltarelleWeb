using System.Html.Media.Graphics;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'CANVAS'"), ScriptName("Element")]
	public partial class CanvasElement : Element {
		internal CanvasElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<CanvasElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<CanvasElement> listener, bool capture) {
		}

		public CanvasRenderingContext GetContext(string contextId) {
			return default(CanvasRenderingContext);
		}

		public CanvasRenderingContext GetContext(string contextId, object contextOptions) {
			return default(CanvasRenderingContext);
		}

		[IntrinsicProperty]
		public uint Height {
			get {
				return 0;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<CanvasElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<CanvasElement> listener, bool capture) {
		}

		public void ToBlob(Action<Blob> callback) {
		}

		public void ToBlob(Action<Blob> callback, string type) {
		}

		public void ToBlob(Action<Blob> callback, string type, object encoderOptions) {
		}

		public string ToDataURL() {
			return null;
		}

		public string ToDataURL(string type) {
			return null;
		}

		public string ToDataURL(string type, object encoderOptions) {
			return null;
		}

		[IntrinsicProperty]
		public uint Width {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
