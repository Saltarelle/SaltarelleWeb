namespace Bridge.Html5.Nodes
{
	[Namespace(false), External]
	public partial class TreeWalker
	{
		internal extern TreeWalker();

		public Node CurrentNode;

		public readonly INodeFilter Filter;

		public extern Node FirstChild();

		public extern Node LastChild();

		public extern Node NextNode();

		public extern Node NextSibling();

		public extern Node ParentNode();

		public extern Node PreviousNode();

		public extern Node PreviousSibling();

		public readonly Node Root;

		public readonly NodeFilter WhatToShow;
	}
}
