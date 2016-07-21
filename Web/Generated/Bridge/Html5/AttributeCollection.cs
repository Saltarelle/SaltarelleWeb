using Bridge.Html5.Nodes;
using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace(false), External, Name("Object")]
	public partial class AttributeCollection : IEnumerable<Attr>
	{
		internal extern AttributeCollection();

		public extern Attr this[int index]
		{
			get;
		}

		public extern Attr this[string name]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<Attr> GetEnumerator();

		public extern Attr GetNamedItem(string name);

		public extern Attr GetNamedItemNS(string namespaceURI, string localName);

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern Attr Item(int index);

		public readonly int Length;

		public extern Attr RemoveNamedItem(string name);

		public extern Attr RemoveNamedItemNS(string namespaceURI, string localName);

		public extern Attr SetNamedItem(Attr arg);

		public extern Attr SetNamedItemNS(Attr arg);
	}
}
