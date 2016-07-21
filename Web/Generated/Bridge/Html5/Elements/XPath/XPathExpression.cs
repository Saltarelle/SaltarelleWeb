using Bridge.Html5.Nodes;

namespace Bridge.Html5.Elements.XPath
{
	[Namespace(false), External]
	public partial class XPathExpression
	{
		internal extern XPathExpression();

		public extern XPathResult Evaluate(Node contextNode, ResultType type, XPathResult result);
	}
}
