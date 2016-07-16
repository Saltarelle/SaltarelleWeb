using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("HTMLCollection")]
	public partial class ElementCollection
	{
		internal extern ElementCollection();

		[IndexerName("__Item"), FieldProperty]
		public Element this[int index]
		{
			get;
		}

		[IndexerName("__Item"), FieldProperty]
		public Element this[string name]
		{
			get;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<Element> GetEnumerator();

		public extern Element Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}

		public extern Element NamedItem(string name);
	}
}
