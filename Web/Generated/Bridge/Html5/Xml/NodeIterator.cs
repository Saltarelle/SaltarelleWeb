namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class NodeIterator
	{
		internal extern NodeIterator();

		public extern void Detach();

		[FieldProperty]
		public extern INodeFilter Filter
		{
			get;
		}

		public extern XmlNode NextNode();

		[FieldProperty]
		public extern bool PointerBeforeReferenceNode
		{
			get;
		}

		public extern XmlNode PreviousNode();

		[FieldProperty]
		public extern XmlNode ReferenceNode
		{
			get;
		}

		[FieldProperty]
		public extern XmlNode Root
		{
			get;
		}

		[FieldProperty]
		public extern NodeFilter WhatToShow
		{
			get;
		}
	}
}
