// SqlResultSetRow.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Data.Sql {
	[IgnoreNamespace]
	[Imported]
	public sealed class SqlResultSetRow {
		private SqlResultSetRow() {
		}

		[IntrinsicProperty]
		public object this[string name] {
			get { return null; }
		}
	}
}