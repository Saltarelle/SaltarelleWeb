using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class WorkerNavigator {
		internal WorkerNavigator() {
		}

		[IntrinsicProperty]
		public string AppCodeName {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string AppName {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string AppVersion {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string Platform {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string Product {
			get {
				return null;
			}
		}

		public bool TaintEnabled() {
			return false;
		}

		[IntrinsicProperty]
		public string UserAgent {
			get {
				return null;
			}
		}
	}
}
