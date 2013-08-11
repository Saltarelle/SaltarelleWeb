// ResultType.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Xml.XPath {
	[Imported]
	public enum ResultType {
		Any = 0,
		Number = 1,
		String = 2,
		Boolean = 3,
		UnorderedNodeIterator = 4,
		OrderedNodeIterator = 5,
		UnorderedNodeSnapshot = 6,
		OrderedNodeSnapshot = 7,
		AnyUnorderedNode = 8,
		FirstOrderedNode = 9,
	}
}
