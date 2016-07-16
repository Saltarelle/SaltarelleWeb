using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMStringList
	{
		internal extern DOMStringList();

		[IndexerName("__Item"), FieldProperty]
		public string this[int index]
		{
			get;
		}

		public extern bool Contains(string @string);

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<string> GetEnumerator();

		public extern string Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}
	}
}
