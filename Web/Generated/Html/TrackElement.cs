using System.Html.Media;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TRACK'"), ScriptName("Element")]
	public partial class TrackElement : Element {
		internal TrackElement() {
		}

		[IntrinsicProperty]
		public bool Default {
			get {
				return false;
			}
			set {
			}
		}

		public const ushort ERROR = 3;

		[IntrinsicProperty]
		public TextTrackKind Kind {
			get {
				return default(TextTrackKind);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Label {
			get {
				return null;
			}
			set {
			}
		}

		public const ushort LOADED = 2;

		public const ushort LOADING = 1;

		public const ushort NONE = 0;

		[IntrinsicProperty]
		public ushort ReadyState {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public string Src {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Srclang {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public TextTrack Track {
			get {
				return default(TextTrack);
			}
		}
	}
}
