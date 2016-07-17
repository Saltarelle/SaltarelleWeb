using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class StyleSheetList : IEnumerable<StyleSheet>
	{
		internal extern StyleSheetList();

		public extern StyleSheet this[int index]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<StyleSheet> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern StyleSheet Item(int index);

		public readonly int Length;
	}
}
