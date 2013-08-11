// ElementAttributeCollection.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace]
	[Imported]
	public sealed class ElementAttributeCollection {
		internal ElementAttributeCollection() {
		}

		[IntrinsicProperty]
		[ScriptName("length")]
		public int Count {
			get { return 0; }
		}

		public ElementAttribute GetNamedItem(string name) {
			return null;
		}

		[ScriptName("item")]
		public ElementAttribute Item(int i) {
			return null;
		}

		[IntrinsicProperty]
		public int Length {
			get { return 0; }
		}

		public ElementAttribute RemoveNamedItem(string name) {
			return null;
		}

		public ElementAttribute SetNamedItem(ElementAttribute attribute) {
			return null;
		}

		[IndexerName("XItem")]
		public ElementAttribute this[int i] {
			[ScriptName("item")] get { return null; }
		}
	}
}