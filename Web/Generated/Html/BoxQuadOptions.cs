using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[Imported, Serializable]
	public partial class BoxQuadOptions {
		public CSSBoxType Box {
			get;
			set;
		}

		public TypeOption<XmlText, Element, DocumentBase> RelativeTo {
			get;
			set;
		}
	}
}
