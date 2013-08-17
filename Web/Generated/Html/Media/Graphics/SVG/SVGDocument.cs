using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGDocument : DocumentBase {
		internal SVGDocument() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGDocument> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGDocument> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Domain {
			get {
				return null;
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGDocument> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGDocument> listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGElement RootElement {
			get {
				return default(SVGElement);
			}
		}
	}
}
