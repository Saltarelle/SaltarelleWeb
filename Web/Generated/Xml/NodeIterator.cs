using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class NodeIterator {
		internal NodeIterator() {
		}

		public void Detach() {
		}

		[IntrinsicProperty]
		public INodeFilter Filter {
			get {
				return default(INodeFilter);
			}
		}

		public XmlNode NextNode() {
			return default(XmlNode);
		}

		[IntrinsicProperty]
		public bool PointerBeforeReferenceNode {
			get {
				return false;
			}
		}

		public XmlNode PreviousNode() {
			return default(XmlNode);
		}

		[IntrinsicProperty]
		public XmlNode ReferenceNode {
			get {
				return default(XmlNode);
			}
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
