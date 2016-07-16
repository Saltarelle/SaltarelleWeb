namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class NodeIterator
	{
		internal NodeIterator()
		{
		}

		public void Detach()
		{
		}

		[FieldProperty]
		public INodeFilter Filter
		{
			get {
				return default(INodeFilter);
			}
		}

		public XmlNode NextNode()
		{
			return default(XmlNode);
		}

		[FieldProperty]
		public bool PointerBeforeReferenceNode
		{
			get {
				return false;
			}
		}

		public XmlNode PreviousNode()
		{
			return default(XmlNode);
		}

		[FieldProperty]
		public XmlNode ReferenceNode
		{
			get {
				return default(XmlNode);
			}
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
