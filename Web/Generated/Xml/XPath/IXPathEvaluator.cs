// IXPathEvaluator.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Xml.XPath {
	[IgnoreNamespace, Imported]
	public partial interface IXPathEvaluator {
		XPathExpression CreateExpression(string expression, XPathNSResolver resolver);

		XPathNSResolver CreateNSResolver(XmlNode nodeResolver);

		XPathResult Evaluate(string expression, XmlNode contextNode, XPathNSResolver resolver, ushort type, XPathResult result);
	}
}
