using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ValidityState {
		internal ValidityState() {
		}

		[IntrinsicProperty]
		public bool CustomError {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public bool PatternMismatch {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public bool RangeOverflow {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public bool RangeUnderflow {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public bool StepMismatch {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public bool TooLong {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public bool TypeMismatch {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public bool Valid {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public bool ValueMissing {
			get {
				return false;
			}
		}
	}
}
