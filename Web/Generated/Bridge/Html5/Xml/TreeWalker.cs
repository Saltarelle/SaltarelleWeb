namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TreeWalker
	{
		internal TreeWalker()
		{
		}

		[FieldProperty]
		public XmlNode CurrentNode
		{
			get {
				return default(XmlNode);
			}
			set {
			}
		}

		[FieldProperty]
		public INodeFilter Filter
		{
			get {
				return default(INodeFilter);
			}
		}

		public XmlNode FirstChild()
		{
			return default(XmlNode);
		}

		public XmlNode LastChild()
		{
			return default(XmlNode);
		}

		public XmlNode NextNode()
		{
			return default(XmlNode);
		}

		public XmlNode NextSibling()
		{
			return default(XmlNode);
		}

		public XmlNode ParentNode()
		{
			return default(XmlNode);
		}

		public XmlNode PreviousNode()
		{
			return default(XmlNode);
		}

		public XmlNode PreviousSibling()
		{
			return default(XmlNode);
		}

		[FieldProperty]
		public XmlNode Root
		{
			get {
				return default(XmlNode);
			}
		}

		[FieldProperty]
		public NodeFilter WhatToShow
		{
			get {
				return default(NodeFilter);
			}
		}
	}
}
