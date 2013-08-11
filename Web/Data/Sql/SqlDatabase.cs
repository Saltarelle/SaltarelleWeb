// SqlDatabase.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Data {
	[IgnoreNamespace]
	[Imported]
	public sealed class SqlDatabase {
		private SqlDatabase() {
		}

		public void ChangeVersion(string oldVersion, string newVersion, SqlTransactionCallback callback, SqlErrorCallback errorCallback, Action successCallback) {
		}

		public void ReadTransaction(SqlTransactionCallback callback, SqlErrorCallback errorCallback, Action successCallback) {
		}

		public void Transaction(SqlTransactionCallback callback, SqlErrorCallback errorCallback, Action successCallback) {
		}

		[IntrinsicProperty]
		public string Version {
			get { return null; }
		}
	}
}