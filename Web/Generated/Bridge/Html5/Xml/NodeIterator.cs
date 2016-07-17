namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class NodeIterator
	{
		internal extern NodeIterator();

		public extern void Detach();

		public readonly INodeFilter Filter;

		public extern XmlNode NextNode();

		public readonly bool PointerBeforeReferenceNode;

		public extern XmlNode PreviousNode();

		public readonly XmlNode ReferenceNode;

		public readonly XmlNode Root;

		public readonly NodeFilter WhatToShow;
	}
}
