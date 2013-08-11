// IWindowTimers.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported]
	public partial interface IWindowTimers {
		void ClearInterval(int intervalId);

		void ClearTimeout(int timeoutId);

		int SetInterval(Function func);

		[ExpandParams]
		int SetInterval(Function func, int delay, params object[] args);

		int SetInterval(string code);

		int SetInterval(string code, int delay);

		int SetTimeout(Function func);

		[ExpandParams]
		int SetTimeout(Function func, int delay, params object[] args);

		int SetTimeout(string code);

		int SetTimeout(string code, int delay);
	}
}
