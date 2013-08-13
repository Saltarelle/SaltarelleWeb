using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class TreeWalker {
		internal TreeWalker() {
		}

		[IntrinsicProperty]
		public XmlNode CurrentNode {
			get {
				return default(XmlNode);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public INodeFilter Filter {
			get {
				return default(INodeFilter);
			}
		}

		public XmlNode FirstChild() {
			return default(XmlNode);
		}

		public XmlNode LastChild() {
			return default(XmlNode);
		}

		public XmlNode NextNode() {
			return default(XmlNode);
		}

		public XmlNode NextSibling() {
			return default(XmlNode);
		}

		public XmlNode ParentNode() {
			return default(XmlNode);
		}

		public XmlNode PreviousNode() {
			return default(XmlNode);
		}

		public XmlNode PreviousSibling() {
			return default(XmlNode);
		}

		[IntrinsicProperty]
		public XmlNode Root {
			get {
				return default(XmlNode);
			}
		}

		[IntrinsicProperty]
		public NodeFilter WhatToShow {
			get {
				return default(NodeFilter);
			}
		}
	}
}
