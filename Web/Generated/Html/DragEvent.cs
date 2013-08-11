using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DragEvent : MouseEvent {
		internal DragEvent() {
		}

		[IntrinsicProperty]
		public DataTransfer DataTransfer {
			get { return default(DataTransfer); }
		}
	}
}
