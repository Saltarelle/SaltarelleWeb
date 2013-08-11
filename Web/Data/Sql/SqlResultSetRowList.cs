// SqlResultSetRowList.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Data {
	[IgnoreNamespace]
	[Imported]
	public sealed class SqlResultSetRowList {
		private SqlResultSetRowList() {
		}

		public SqlResultSetRow Item(int index) {
			return null;
		}

		[IntrinsicProperty]
		public int Length {
			get { return 0; }
		}
	}
}