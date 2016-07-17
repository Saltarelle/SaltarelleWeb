using Bridge.Html5.Xml;
using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Object")]
	public partial class AttributeCollection : IEnumerable<XmlAttribute>
	{
		internal extern AttributeCollection();

		public extern XmlAttribute this[int index]
		{
			get;
		}

		public extern XmlAttribute this[string name]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<XmlAttribute> GetEnumerator();

		public extern XmlAttribute GetNamedItem(string name);

		public extern XmlAttribute GetNamedItemNS(string namespaceURI, string localName);

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern XmlAttribute Item(int index);

		public readonly int Length;

		public extern XmlAttribute RemoveNamedItem(string name);

		public extern XmlAttribute RemoveNamedItemNS(string namespaceURI, string localName);

		public extern XmlAttribute SetNamedItem(XmlAttribute arg);

		public extern XmlAttribute SetNamedItemNS(XmlAttribute arg);
	}
}
