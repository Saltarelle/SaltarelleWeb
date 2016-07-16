using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.WebStorage {
	[Imported, Serializable]
	public partial class StorageEventInit : EventInit {
		public string Key {
			get;
			set;
		}

		public string NewValue {
			get;
			set;
		}

		public string OldValue {
			get;
			set;
		}

		public Storage StorageArea {
			get;
			set;
		}

		public string Url {
			get;
			set;
		}
	}
}
