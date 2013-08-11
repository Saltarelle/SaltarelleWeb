using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[Imported, Serializable]
	public partial class MediaStreamEventInit : EventInit {
		public MediaStream Stream {
			get { return default(MediaStream); }
			set { }
		}
	}
}
