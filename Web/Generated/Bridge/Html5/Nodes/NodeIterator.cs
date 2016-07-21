using Bridge.Html5.Elements;

namespace Bridge.Html5.Nodes
{
	[Namespace(false), External]
	public partial class NodeIterator
	{
		internal extern NodeIterator();

		public extern void Detach();

		public readonly INodeFilter Filter;

		public extern Node NextNode();

		public readonly bool PointerBeforeReferenceNode;

		public extern Node PreviousNode();

		public readonly Node ReferenceNode;

		public readonly Node Root;

		public readonly NodeFilter WhatToShow;
	}
}
