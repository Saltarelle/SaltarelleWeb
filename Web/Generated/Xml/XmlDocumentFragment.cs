// XmlDocumentFragment.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("DocumentFragment")]
	public partial class XmlDocumentFragment : XmlNode {
		public XmlDocumentFragment() {
		}

		[IntrinsicProperty]
		public uint ChildElementCount {
			get { return 0; }
		}

		[IntrinsicProperty]
		public ElementCollection Children {
			get { return default(ElementCollection); }
		}

		[IntrinsicProperty]
		public XmlElement FirstElementChild {
			get { return default(XmlElement); }
		}

		[IntrinsicProperty]
		public XmlElement LastElementChild {
			get { return default(XmlElement); }
		}

		public XmlElement QuerySelector(string selectors) {
			return default(XmlElement);
		}

		public XmlNodeList QuerySelectorAll(string selectors) {
			return default(XmlNodeList);
		}
	}
}
