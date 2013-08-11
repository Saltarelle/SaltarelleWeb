// TokenList.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace]
	[Imported]
	public sealed class TokenList {
		private TokenList() {
		}

		public void Add(string token) {
		}

		public bool Contains(string token) {
			return false;
		}

		[IntrinsicProperty]
		[ScriptName("length")]
		public int Count {
			get { return 0; }
		}

		[IntrinsicProperty]
		public string this[int index] {
			get { return null; }
		}

		public void Remove(string token) {
		}

		public override string ToString() {
			return null;
		}

		public bool Toggle(string token) {
			return false;
		}
	}
}