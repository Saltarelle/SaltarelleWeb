using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DataTransfer {
		internal DataTransfer() {
		}

		public void ClearData() {
		}

		public void ClearData(string format) {
		}

		[IntrinsicProperty]
		public DropEffect DropEffect {
			get {
				return default(DropEffect);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public AllowedDropEffect EffectAllowed {
			get {
				return default(AllowedDropEffect);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public FileList Files {
			get {
				return default(FileList);
			}
		}

		public string GetData(string format) {
			return null;
		}

		[IntrinsicProperty]
		public DataTransferItemList Items {
			get {
				return default(DataTransferItemList);
			}
		}

		public void SetData(string format, string data) {
		}

		public void SetDragImage(XmlElement image, int x, int y) {
		}

		[IntrinsicProperty]
		public string[] Types {
			get {
				return null;
			}
		}
	}
}
