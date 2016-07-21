using Bridge.Html5.Nodes;

namespace Bridge.Html5.Elements.XPath
{
	[Namespace(false), External]
	public partial class XPathResult
	{
		internal extern XPathResult();

		[Name("ANY_TYPE")]
		public const ushort ANY_TYPE = 0;

		[Name("ANY_UNORDERED_NODE_TYPE")]
		public const ushort ANY_UNORDERED_NODE_TYPE = 8;

		[Name("BOOLEAN_TYPE")]
		public const ushort BOOLEAN_TYPE = 3;

		public readonly bool BooleanValue;

		[Name("FIRST_ORDERED_NODE_TYPE")]
		public const ushort FIRST_ORDERED_NODE_TYPE = 9;

		public readonly bool InvalidIteratorState;

		public extern Node IterateNext();

		[Name("NUMBER_TYPE")]
		public const ushort NUMBER_TYPE = 1;

		public readonly double NumberValue;

		[Name("ORDERED_NODE_ITERATOR_TYPE")]
		public const ushort ORDERED_NODE_ITERATOR_TYPE = 5;

		[Name("ORDERED_NODE_SNAPSHOT_TYPE")]
		public const ushort ORDERED_NODE_SNAPSHOT_TYPE = 7;

		public readonly ResultType ResultType;

		public readonly Node SingleNodeValue;

		public extern Node SnapshotItem(int index);

		public readonly int SnapshotLength;

		[Name("STRING_TYPE")]
		public const ushort STRING_TYPE = 2;

		public readonly string StringValue;

		[Name("UNORDERED_NODE_ITERATOR_TYPE")]
		public const ushort UNORDERED_NODE_ITERATOR_TYPE = 4;

		[Name("UNORDERED_NODE_SNAPSHOT_TYPE")]
		public const ushort UNORDERED_NODE_SNAPSHOT_TYPE = 6;
	}
}
