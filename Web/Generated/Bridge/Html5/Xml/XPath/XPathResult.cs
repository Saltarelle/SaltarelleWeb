﻿namespace Bridge.Html5.Xml.XPath
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class XPathResult
	{
		internal XPathResult()
		{
		}

		[Name("ANY_TYPE")]
		public const ushort ANY_TYPE = 0;

		[Name("ANY_UNORDERED_NODE_TYPE")]
		public const ushort ANY_UNORDERED_NODE_TYPE = 8;

		[Name("BOOLEAN_TYPE")]
		public const ushort BOOLEAN_TYPE = 3;

		[FieldProperty]
		public bool BooleanValue
		{
			get {
				return false;
			}
		}

		[Name("FIRST_ORDERED_NODE_TYPE")]
		public const ushort FIRST_ORDERED_NODE_TYPE = 9;

		[FieldProperty]
		public bool InvalidIteratorState
		{
			get {
				return false;
			}
		}

		public XmlNode IterateNext()
		{
			return default(XmlNode);
		}

		[Name("NUMBER_TYPE")]
		public const ushort NUMBER_TYPE = 1;

		[FieldProperty]
		public double NumberValue
		{
			get {
				return 0;
			}
		}

		[Name("ORDERED_NODE_ITERATOR_TYPE")]
		public const ushort ORDERED_NODE_ITERATOR_TYPE = 5;

		[Name("ORDERED_NODE_SNAPSHOT_TYPE")]
		public const ushort ORDERED_NODE_SNAPSHOT_TYPE = 7;

		[FieldProperty]
		public ResultType ResultType
		{
			get {
				return default(ResultType);
			}
		}

		[FieldProperty]
		public XmlNode SingleNodeValue
		{
			get {
				return default(XmlNode);
			}
		}

		public XmlNode SnapshotItem(int index)
		{
			return default(XmlNode);
		}

		[FieldProperty]
		public int SnapshotLength
		{
			get {
				return 0;
			}
		}

		[Name("STRING_TYPE")]
		public const ushort STRING_TYPE = 2;

		[FieldProperty]
		public string StringValue
		{
			get {
				return null;
			}
		}

		[Name("UNORDERED_NODE_ITERATOR_TYPE")]
		public const ushort UNORDERED_NODE_ITERATOR_TYPE = 4;

		[Name("UNORDERED_NODE_SNAPSHOT_TYPE")]
		public const ushort UNORDERED_NODE_SNAPSHOT_TYPE = 6;
	}
}