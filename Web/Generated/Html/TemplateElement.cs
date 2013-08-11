// TemplateElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

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
