// XPathExpression.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

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
