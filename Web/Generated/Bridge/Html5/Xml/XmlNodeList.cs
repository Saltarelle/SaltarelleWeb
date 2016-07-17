using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Xml
{
	[Namespace(false), External, Name("NodeList")]
	public partial class XmlNodeList : IEnumerable<XmlNode>
	{
		internal extern XmlNodeList();

		public extern XmlNode this[int index]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<XmlNode> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern XmlNode Item(int index);

		public readonly int Length;
	}
}
