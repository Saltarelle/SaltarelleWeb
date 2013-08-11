using System.Runtime.CompilerServices;

namespace System.Xml.XPath {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class XPathExpression {
		internal XPathExpression() {
		}

		public XPathResult Evaluate(XmlNode contextNode, ResultType type, XPathResult result) {
			return default(XPathResult);
		}
	}
}
