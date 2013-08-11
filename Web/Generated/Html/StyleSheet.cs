using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class StyleSheet {
		internal StyleSheet() {
		}

		[IntrinsicProperty]
		public bool Disabled {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public string Href {
			get { return null; }
		}

		[IntrinsicProperty]
		public MediaList Media {
			get { return default(MediaList); }
		}

		[IntrinsicProperty]
		public XmlNode OwnerNode {
			get { return default(XmlNode); }
		}

		[IntrinsicProperty]
		public StyleSheet ParentStyleSheet {
			get { return default(StyleSheet); }
		}

		[IntrinsicProperty]
		public string Title {
			get { return null; }
		}

		[IntrinsicProperty]
		public string Type {
			get { return null; }
		}
	}
}
