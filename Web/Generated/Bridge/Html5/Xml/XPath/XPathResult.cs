namespace Bridge.Html5.Xml.XPath
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class XPathResult
	{
		internal extern XPathResult();

		[Name("ANY_TYPE")]
		public const ushort ANY_TYPE = 0;

		[Name("ANY_UNORDERED_NODE_TYPE")]
		public const ushort ANY_UNORDERED_NODE_TYPE = 8;

		[Name("BOOLEAN_TYPE")]
		public const ushort BOOLEAN_TYPE = 3;

		[FieldProperty]
		public extern bool BooleanValue
		{
			get;
		}

		[Name("FIRST_ORDERED_NODE_TYPE")]
		public const ushort FIRST_ORDERED_NODE_TYPE = 9;

		[FieldProperty]
		public extern bool InvalidIteratorState
		{
			get;
		}

		public extern XmlNode IterateNext();

		[Name("NUMBER_TYPE")]
		public const ushort NUMBER_TYPE = 1;

		[FieldProperty]
		public extern double NumberValue
		{
			get;
		}

		[Name("ORDERED_NODE_ITERATOR_TYPE")]
		public const ushort ORDERED_NODE_ITERATOR_TYPE = 5;

		[Name("ORDERED_NODE_SNAPSHOT_TYPE")]
		public const ushort ORDERED_NODE_SNAPSHOT_TYPE = 7;

		[FieldProperty]
		public extern ResultType ResultType
		{
			get;
		}

		[FieldProperty]
		public extern XmlNode SingleNodeValue
		{
			get;
		}

		public extern XmlNode SnapshotItem(int index);

		[FieldProperty]
		public extern int SnapshotLength
		{
			get;
		}

		[Name("STRING_TYPE")]
		public const ushort STRING_TYPE = 2;

		[FieldProperty]
		public extern string StringValue
		{
			get;
		}

		[Name("UNORDERED_NODE_ITERATOR_TYPE")]
		public const ushort UNORDERED_NODE_ITERATOR_TYPE = 4;

		[Name("UNORDERED_NODE_SNAPSHOT_TYPE")]
		public const ushort UNORDERED_NODE_SNAPSHOT_TYPE = 6;
	}
}
