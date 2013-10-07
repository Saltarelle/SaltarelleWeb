using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CaretPosition {
		internal CaretPosition() {
		}

		public DOMRect GetClientRect() {
			return default(DOMRect);
		}

		[IntrinsicProperty]
		public uint Offset {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public XmlNode OffsetNode {
			get {
				return default(XmlNode);
			}
		}
	}
}
