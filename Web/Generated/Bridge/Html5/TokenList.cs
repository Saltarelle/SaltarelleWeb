using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace(false), External, Name("DOMTokenList")]
	public partial class TokenList : IEnumerable<string>
	{
		internal extern TokenList();

		public extern string this[int index]
		{
			get;
		}

		[ExpandParams]
		public extern void Add(params string[] tokens);

		public extern bool Contains(string token);

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<string> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern string Item(int index);

		public readonly int Length;

		[ExpandParams]
		public extern void Remove(params string[] tokens);

		public extern bool Toggle(string token);

		public extern bool Toggle(string token, bool force);
	}
}
