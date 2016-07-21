using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Nodes
{
	[Namespace(false), External]
	public partial class HTMLCollection : IEnumerable<Element>
	{
		internal extern HTMLCollection();

		public extern Element this[int index]
		{
			get;
		}

		public extern Element this[string name]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<Element> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern Element Item(int index);

		public readonly int Length;

		public extern Element NamedItem(string name);
	}
}
