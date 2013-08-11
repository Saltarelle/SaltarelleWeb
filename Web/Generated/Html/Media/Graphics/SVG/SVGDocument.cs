using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGDocument : DocumentBase {
		internal SVGDocument() {
		}

		[IntrinsicProperty]
		public string Domain {
			get { return null; }
		}

		[IntrinsicProperty]
		public SVGElement RootElement {
			get { return default(SVGElement); }
		}
	}
}
