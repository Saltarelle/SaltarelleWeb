namespace Bridge.Html5.Xml
{
	[Namespace(false), External]
	public partial class TreeWalker
	{
		internal extern TreeWalker();

		public XmlNode CurrentNode;

		public readonly INodeFilter Filter;

		public extern XmlNode FirstChild();

		public extern XmlNode LastChild();

		public extern XmlNode NextNode();

		public extern XmlNode NextSibling();

		public extern XmlNode ParentNode();

		public extern XmlNode PreviousNode();

		public extern XmlNode PreviousSibling();

		public readonly XmlNode Root;

		public readonly NodeFilter WhatToShow;
	}
}
