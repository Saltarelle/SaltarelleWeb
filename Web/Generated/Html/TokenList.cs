using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("DOMTokenList")]
	public partial class TokenList {
		internal TokenList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public string this[uint index] {
			get {
				return null;
			}
		}

		[ExpandParams]
		public void Add(params string[] tokens) {
		}

		public bool Contains(string token) {
			return false;
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<string> GetEnumerator() {
			return null;
		}

		public string Item(uint index) {
			return null;
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		[ExpandParams]
		public void Remove(params string[] tokens) {
		}

		public bool Toggle(string token) {
			return false;
		}

		public bool Toggle(string token, bool force) {
			return false;
		}
	}
}
