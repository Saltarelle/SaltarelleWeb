using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class StyleSheetList
	{
		internal extern StyleSheetList();

		[IndexerName("__Item"), FieldProperty]
		public StyleSheet this[int index]
		{
			get;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<StyleSheet> GetEnumerator();

		public extern StyleSheet Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}
	}
}
