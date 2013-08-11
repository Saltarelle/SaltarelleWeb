using System.Runtime.CompilerServices;

namespace System.Data.WebStorage {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class Storage {
		internal Storage() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public string this[string key] {
			get { return null; }
			set { }
		}

		public void Clear() {
		}

		public string GetItem(string key) {
			return null;
		}

		public string Key(uint index) {
			return null;
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}

		public void RemoveItem(string key) {
		}

		public void SetItem(string key, string value) {
		}
	}
}
