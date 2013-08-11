// SqlTransaction.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Data.Sql {
	[IgnoreNamespace]
	[Imported]
	public sealed class SqlTransaction {
		private SqlTransaction() {
		}

		public void ExecuteSql(string sql, object[] arguments, SqlStatementCallback callback, SqlStatementErrorCallback errorCallback) {
		}
	}
}