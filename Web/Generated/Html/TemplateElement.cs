using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TEMPLATE'"), ScriptName("Element")]
	public partial class TemplateElement : Element {
		internal TemplateElement() {
		}

		[IntrinsicProperty]
		public XmlDocumentFragment Content {
			get { return default(XmlDocumentFragment); }
		}
	}
}
