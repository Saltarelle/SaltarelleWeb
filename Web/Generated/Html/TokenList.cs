// TokenList.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("DOMTokenList")]
	public partial class TokenList {
		internal TokenList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public string this[uint index] {
			get { return null; }
		}

		public void Add(string token) {
		}

		public bool Contains(string token) {
			return false;
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<string> GetEnumerator() {
			return default(IEnumerator<string>);
		}

		public string Item(uint index) {
			return null;
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}

		public void Remove(string token) {
		}

		public bool Toggle(string token) {
			return false;
		}

		public bool Toggle(string token, bool force) {
			return false;
		}
	}
}
