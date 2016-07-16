using Bridge.Html5.Xml;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class AttributeCollection
	{
		internal AttributeCollection()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public XmlAttribute this[int index]
		{
			get {
				return default(XmlAttribute);
			}
		}

		[IndexerName("__Item"), FieldProperty]
		public XmlAttribute this[string name]
		{
			get {
				return default(XmlAttribute);
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<XmlAttribute> GetEnumerator()
		{
			return null;
		}

		public XmlAttribute GetNamedItem(string name)
		{
			return default(XmlAttribute);
		}

		public XmlAttribute GetNamedItemNS(string namespaceURI, string localName)
		{
			return default(XmlAttribute);
		}

		public XmlAttribute Item(int index)
		{
			return default(XmlAttribute);
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}

		public XmlAttribute RemoveNamedItem(string name)
		{
			return default(XmlAttribute);
		}

		public XmlAttribute RemoveNamedItemNS(string namespaceURI, string localName)
		{
			return default(XmlAttribute);
		}

		public XmlAttribute SetNamedItem(XmlAttribute arg)
		{
			return default(XmlAttribute);
		}

		public XmlAttribute SetNamedItemNS(XmlAttribute arg)
		{
			return default(XmlAttribute);
		}
	}
}
