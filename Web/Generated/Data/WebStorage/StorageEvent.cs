using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.WebStorage {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class StorageEvent : Event {
		internal StorageEvent() {
		}

		public StorageEvent(string type) {
		}

		public StorageEvent(string type, StorageEventInit eventInitDict) {
		}

		public void InitStorageEvent(string type, bool canBubble, bool cancelable, string key, string oldValue, string newValue, string url, Storage storageArea) {
		}

		[IntrinsicProperty]
		public string Key {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string NewValue {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string OldValue {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public Storage StorageArea {
			get {
				return default(Storage);
			}
		}

		[IntrinsicProperty]
		public string Url {
			get {
				return null;
			}
		}
	}
}
