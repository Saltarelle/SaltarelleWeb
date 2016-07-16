using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class StyleSheetList
	{
		internal StyleSheetList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public StyleSheet this[int index]
		{
			get {
				return default(StyleSheet);
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<StyleSheet> GetEnumerator()
		{
			return null;
		}

		public StyleSheet Item(int index)
		{
			return default(StyleSheet);
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}
	}
}
