using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	[Imported, Serializable]
	public partial class WebGLContextAttributes {
		public bool Alpha {
			get;
			set;
		}

		public bool Antialias {
			get;
			set;
		}

		public bool Depth {
			get;
			set;
		}

		public bool PremultipliedAlpha {
			get;
			set;
		}

		public bool PreserveDrawingBuffer {
			get;
			set;
		}

		public bool Stencil {
			get;
			set;
		}
	}
}
