namespace Bridge.Html5.Xml.XPath
{
	[Namespace(false), External]
	public partial interface IXPathEvaluator
	{
		XPathExpression CreateExpression(string expression, XPathNSResolver resolver);

		XPathNSResolver CreateNSResolver(XmlNode nodeResolver);

		XPathResult Evaluate(string expression, XmlNode contextNode, XPathNSResolver resolver, ushort type, XPathResult result);
	}
}
