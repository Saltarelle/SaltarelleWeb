// MutationRecord.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MutationRecord {
		internal MutationRecord() {
		}

		[IntrinsicProperty]
		public XmlNodeList AddedNodes {
			get { return default(XmlNodeList); }
		}

		[IntrinsicProperty]
		public string AttributeName {
			get { return null; }
		}

		[IntrinsicProperty]
		public string AttributeNamespace {
			get { return null; }
		}

		[IntrinsicProperty]
		public XmlNode NextSibling {
			get { return default(XmlNode); }
		}

		[IntrinsicProperty]
		public string OldValue {
			get { return null; }
		}

		[IntrinsicProperty]
		public XmlNode PreviousSibling {
			get { return default(XmlNode); }
		}

		[IntrinsicProperty]
		public XmlNodeList RemovedNodes {
			get { return default(XmlNodeList); }
		}

		[IntrinsicProperty]
		public XmlNode Target {
			get { return default(XmlNode); }
		}

		[IntrinsicProperty]
		public string Type {
			get { return null; }
		}
	}
}
