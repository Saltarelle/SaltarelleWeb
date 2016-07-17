using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class MimeTypeArray : IEnumerable<MimeType>
	{
		internal extern MimeTypeArray();

		public extern MimeType this[int index]
		{
			get;
		}

		public extern MimeType this[string name]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<MimeType> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern MimeType Item(int index);

		public readonly int Length;

		public extern MimeType NamedItem(string name);
	}
}
