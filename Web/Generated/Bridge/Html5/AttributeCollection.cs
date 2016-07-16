using Bridge.Html5.Xml;
using System.Collections.Generic;

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

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<XmlAttribute> GetEnumerator();

		public extern XmlAttribute GetNamedItem(string name);

		public extern XmlAttribute GetNamedItemNS(string namespaceURI, string localName);

		public extern XmlAttribute Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}

		public extern XmlAttribute RemoveNamedItem(string name);

		public extern XmlAttribute RemoveNamedItemNS(string namespaceURI, string localName);

		public extern XmlAttribute SetNamedItem(XmlAttribute arg);

		public extern XmlAttribute SetNamedItemNS(XmlAttribute arg);
	}
}
