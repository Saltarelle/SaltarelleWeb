using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Nodes
{
	[Namespace(false), External]
	public partial class NodeList : IEnumerable<Node>
	{
		internal extern NodeList();

		public extern Node this[int index]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<Node> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern Node Item(int index);

		public readonly int Length;
	}
}
