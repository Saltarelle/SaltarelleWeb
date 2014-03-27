using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class ConvertCoordinateOptions {
		public CSSBoxType FromBox {
			get;
			set;
		}

		public CSSBoxType ToBox {
			get;
			set;
		}
	}
}
