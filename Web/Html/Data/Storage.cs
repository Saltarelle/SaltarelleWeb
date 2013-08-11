// Storage.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Data {
	[IgnoreNamespace]
	[Imported]
	public sealed class Storage {
		private Storage() {
		}

		public void Clear() {
		}

		public object GetItem(string key) {
			return null;
		}

		[ScriptName("key")]
		public string GetKey(int index) {
			return null;
		}

		[IntrinsicProperty]
		public object this[string key] {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public int Length {
			get { return 0; }
		}

		public void RemoveItem(string key) {
		}

		public void SetItem(string key, object value) {
		}
	}
}