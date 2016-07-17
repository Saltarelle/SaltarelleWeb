namespace Bridge.Html5.Xml.XPath
{
	[Namespace(false), External]
	public partial interface IXPathEvaluator
	{
		extern XPathExpression CreateExpression(string expression, XPathNSResolver resolver);

		extern XPathNSResolver CreateNSResolver(XmlNode nodeResolver);

		extern XPathResult Evaluate(string expression, XmlNode contextNode, XPathNSResolver resolver, ushort type, XPathResult result);
	}
}
