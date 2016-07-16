namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TreeWalker
	{
		internal extern TreeWalker();

		[FieldProperty]
		public extern XmlNode CurrentNode
		{
			get;
			set;
		}

		[FieldProperty]
		public extern INodeFilter Filter
		{
			get;
		}

		public extern XmlNode FirstChild();

		public extern XmlNode LastChild();

		public extern XmlNode NextNode();

		public extern XmlNode NextSibling();

		public extern XmlNode ParentNode();

		public extern XmlNode PreviousNode();

		public extern XmlNode PreviousSibling();

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
