using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class AttributeCollection
	{
		internal extern AttributeCollection();

		[IndexerName("__Item"), FieldProperty]
		public XmlAttribute this[int index]
		{
			get;
		}

		[IndexerName("__Item"), FieldProperty]
		public XmlAttribute this[string name]
		{
			get;
		}

		public extern XmlAttribute GetNamedItem(string name);

		public extern XmlAttribute GetNamedItemNS(string namespaceURI, string localName);

		public extern XmlAttribute Item(int index);

		public readonly int Length;

		public extern XmlAttribute RemoveNamedItem(string name);

		public extern XmlAttribute RemoveNamedItemNS(string namespaceURI, string localName);

		public extern XmlAttribute SetNamedItem(XmlAttribute arg);

		public extern XmlAttribute SetNamedItemNS(XmlAttribute arg);
	}
}
