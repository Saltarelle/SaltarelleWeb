using Bridge.Html5.Nodes;

namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class CaretPosition
	{
		internal extern CaretPosition();

		public extern DOMRect GetClientRect();

		public readonly int Offset;

		public readonly Node OffsetNode;
	}
}
