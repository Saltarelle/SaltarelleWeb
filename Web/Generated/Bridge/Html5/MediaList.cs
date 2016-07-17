using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class MediaList : IEnumerable<string>
	{
		internal extern MediaList();

		public extern string this[int index]
		{
			get;
		}

		public extern void AppendMedium(string newMedium);

		public extern void DeleteMedium(string oldMedium);

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<string> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern string Item(int index);

		public readonly int Length;

		public string MediaText;
	}
}
