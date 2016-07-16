using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("HTMLCollection")]
	public partial class ElementCollection
	{
		internal ElementCollection()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public Element this[int index]
		{
			get {
				return default(Element);
			}
		}

		[IndexerName("__Item"), FieldProperty]
		public Element this[string name]
		{
			get {
				return default(Element);
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<Element> GetEnumerator()
		{
			return null;
		}

		public Element Item(int index)
		{
			return default(Element);
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}

		public Element NamedItem(string name)
		{
			return default(Element);
		}
	}
}
