using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MimeType {
		internal MimeType() {
		}

		[IntrinsicProperty]
		public string Description {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public Plugin EnabledPlugin {
			get {
				return default(Plugin);
			}
		}

		[IntrinsicProperty]
		public string Suffixes {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string Type {
			get {
				return null;
			}
		}
	}
}
