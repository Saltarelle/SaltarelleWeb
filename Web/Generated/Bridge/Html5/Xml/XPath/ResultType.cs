namespace Bridge.Html5.Xml.XPath
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum ResultType
	{
		Any = 0,
		AnyUnorderedNode = 8,
		Boolean = 3,
		FirstOrderedNode = 9,
		Number = 1,
		OrderedNodeIterator = 5,
		OrderedNodeSnapshot = 7,
		String = 2,
		UnorderedNodeIterator = 4,
		UnorderedNodeSnapshot = 6
	}
}
