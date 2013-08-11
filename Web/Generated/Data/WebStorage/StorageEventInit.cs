using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.WebStorage {
	[Imported, Serializable]
	public partial class StorageEventInit : EventInit {
		public string Key {
			get { return null; }
			set { }
		}

		public string NewValue {
			get { return null; }
			set { }
		}

		public string OldValue {
			get { return null; }
			set { }
		}

		public Storage StorageArea {
			get { return default(Storage); }
			set { }
		}

		public string Url {
			get { return null; }
			set { }
		}
	}
}
