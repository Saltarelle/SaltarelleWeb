﻿namespace Bridge.Html5.Xml.XPath
{
	[Namespace("false"), External]
	public partial class XPathExpression
	{
		internal extern XPathExpression();

		public extern XPathResult Evaluate(XmlNode contextNode, ResultType type, XPathResult result);
	}
}
