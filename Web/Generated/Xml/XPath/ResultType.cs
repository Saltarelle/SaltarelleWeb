using System.Runtime.CompilerServices;

namespace System.Xml.XPath {
	[Imported]
	public enum ResultType {
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
