using System.Runtime.CompilerServices;

namespace System.Html {
	public partial interface IWindowTimers {
		int SetTimeout(Action handler);
		int SetTimeout(Action handler, int timeout);
		[IncludeGenericArguments(false)]
		int SetTimeout<T1>(Action<T1> handler, int timeout, T1 arg1);
		[IncludeGenericArguments(false)]
		int SetTimeout<T1, T2>(Action<T1> handler, int timeout, T1 arg1, T2 arg2);
		[IncludeGenericArguments(false)]
		int SetTimeout<T1, T2, T3>(Action<T1, T2, T3> handler, int timeout, T1 arg1, T2 arg2, T3 arg3);
		[IncludeGenericArguments(false)]
		int SetTimeout<T1, T2, T3, T4>(Action<T1, T2, T3, T4> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		[IncludeGenericArguments(false)]
		int SetTimeout<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
		[IncludeGenericArguments(false)]
		int SetTimeout<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
		[IncludeGenericArguments(false)]
		int SetTimeout<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
		[IncludeGenericArguments(false)]
		int SetTimeout<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
		[ExpandParams]
		int SetTimeout(Delegate handler, int timeout, params object[] arguments);
		int SetTimeout(string handler);
		int SetTimeout(string handler, int timeout);

		int SetInterval(Action handler);
		int SetInterval(Action handler, int timeout);
		[IncludeGenericArguments(false)]
		int SetInterval<T1>(Action<T1> handler, int timeout, T1 arg1);
		[IncludeGenericArguments(false)]
		int SetInterval<T1, T2>(Action<T1> handler, int timeout, T1 arg1, T2 arg2);
		[IncludeGenericArguments(false)]
		int SetInterval<T1, T2, T3>(Action<T1, T2, T3> handler, int timeout, T1 arg1, T2 arg2, T3 arg3);
		[IncludeGenericArguments(false)]
		int SetInterval<T1, T2, T3, T4>(Action<T1, T2, T3, T4> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		[IncludeGenericArguments(false)]
		int SetInterval<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
		[IncludeGenericArguments(false)]
		int SetInterval<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
		[IncludeGenericArguments(false)]
		int SetInterval<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
		[IncludeGenericArguments(false)]
		int SetInterval<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
		[ExpandParams]
		int SetInterval(Delegate handler, int timeout, params object[] arguments);
		int SetInterval(string handler);
		int SetInterval(string handler, int timeout);
	}
}