using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SourceBuffer : EventTarget {
		internal SourceBuffer() {
		}

		public void Abort() {
		}

		public void AppendBuffer(ArrayBuffer data) {
		}

		public void AppendBuffer(ArrayBufferView data) {
		}

		[IntrinsicProperty]
		public double AppendWindowEnd {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double AppendWindowStart {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public TimeRanges Buffered {
			get {
				return default(TimeRanges);
			}
		}

		[IntrinsicProperty]
		public SourceBufferAppendMode Mode {
			get {
				return default(SourceBufferAppendMode);
			}
			set {
			}
		}

		public void Remove(double start, double end) {
		}

		[IntrinsicProperty]
		public double TimestampOffset {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Updating {
			get {
				return false;
			}
		}
	}
}
