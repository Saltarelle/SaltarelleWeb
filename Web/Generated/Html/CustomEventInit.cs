using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class CustomEventInit : EventInit {
		public object Detail {
			get;
			set;
		}
	}
}
