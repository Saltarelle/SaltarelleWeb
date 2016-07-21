using Bridge.Html5.Nodes;

namespace Bridge.Html5.Elements.XPath
{
	[Namespace(false), External, Name("Object")]
	public partial interface IXPathEvaluator
	{
		XPathExpression CreateExpression(string expression, XPathNSResolver resolver);

		XPathNSResolver CreateNSResolver(Node nodeResolver);

		XPathResult Evaluate(string expression, Node contextNode, XPathNSResolver resolver, ushort type, XPathResult result);
	}
}
