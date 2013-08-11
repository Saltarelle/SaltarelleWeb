// ControlRange.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Editing {
	[IgnoreNamespace]
	[Imported]
	public sealed class ControlRange : Range {
		private ControlRange() {
		}

		public void Add(Element element) {
		}

		public void Add(Element element, int index) {
		}

		[IntrinsicProperty]
		public Element this[int index] {
			get { return null; }
		}

		[IntrinsicProperty]
		public int Length {
			get { return 0; }
		}

		public void Remove(int index) {
		}
	}
}