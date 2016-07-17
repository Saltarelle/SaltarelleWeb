using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class DOMStringList : IEnumerable<string>
	{
		internal extern DOMStringList();

		public extern string this[int index]
		{
			get;
		}

		public extern bool Contains(string @string);

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<string> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern string Item(int index);

		public readonly int Length;
	}
}
