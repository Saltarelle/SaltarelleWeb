// SqlStatementErrorCallback.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

namespace System.Html.Data {
	public delegate bool SqlStatementErrorCallback(SqlTransaction transaction, SqlError error);
}