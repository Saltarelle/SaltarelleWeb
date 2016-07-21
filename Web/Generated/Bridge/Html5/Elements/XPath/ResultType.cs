namespace Bridge.Html5.Elements.XPath
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum ResultType
	{
		Any = 0,
		Number = 1,
		String = 2,
		Boolean = 3,
		UnorderedNodeIterator = 4,
		OrderedNodeIterator = 5,
		UnorderedNodeSnapshot = 6,
		OrderedNodeSnapshot = 7,
		AnyUnorderedNode = 8,
		FirstOrderedNode = 9
	}
}
