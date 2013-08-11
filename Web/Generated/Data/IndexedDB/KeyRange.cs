// KeyRange.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBKeyRange")]
	public partial class KeyRange {
		internal KeyRange() {
		}

		public static KeyRange Bound(object lower, object upper) {
			return default(KeyRange);
		}

		public static KeyRange Bound(object lower, object upper, bool lowerOpen) {
			return default(KeyRange);
		}

		public static KeyRange Bound(object lower, object upper, bool lowerOpen, bool upperOpen) {
			return default(KeyRange);
		}

		[IntrinsicProperty]
		public object Lower {
			get { return null; }
		}

		public static KeyRange LowerBound(object lower) {
			return default(KeyRange);
		}

		public static KeyRange LowerBound(object lower, bool open) {
			return default(KeyRange);
		}

		[IntrinsicProperty]
		public bool LowerOpen {
			get { return false; }
		}

		[ScriptName("only")]
		public static KeyRange OnLy(object value) {
			return default(KeyRange);
		}

		[IntrinsicProperty]
		public object Upper {
			get { return null; }
		}

		public static KeyRange UpperBound(object upper) {
			return default(KeyRange);
		}

		public static KeyRange UpperBound(object upper, bool open) {
			return default(KeyRange);
		}

		[IntrinsicProperty]
		public bool UpperOpen {
			get { return false; }
		}
	}
}
