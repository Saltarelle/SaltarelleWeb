using System.Html;
using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	public partial class WorkerGlobalScope {
		public int SetTimeout(Action handler) { return 0; }
		public int SetTimeout(Action handler, int timeout) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetTimeout<T1>(Action<T1> handler, int timeout, T1 arg1) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetTimeout<T1, T2>(Action<T1> handler, int timeout, T1 arg1, T2 arg2) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetTimeout<T1, T2, T3>(Action<T1, T2, T3> handler, int timeout, T1 arg1, T2 arg2, T3 arg3) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetTimeout<T1, T2, T3, T4>(Action<T1, T2, T3, T4> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetTimeout<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetTimeout<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetTimeout<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetTimeout<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { return 0; }
		[ExpandParams]
		public int SetTimeout(Delegate handler, int timeout, params object[] arguments) { return 0; }
		public int SetTimeout(string handler) { return 0; }
		public int SetTimeout(string handler, int timeout) { return 0; }

		public int SetInterval(Action handler) { return 0; }
		public int SetInterval(Action handler, int timeout) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetInterval<T1>(Action<T1> handler, int timeout, T1 arg1) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetInterval<T1, T2>(Action<T1> handler, int timeout, T1 arg1, T2 arg2) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetInterval<T1, T2, T3>(Action<T1, T2, T3> handler, int timeout, T1 arg1, T2 arg2, T3 arg3) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetInterval<T1, T2, T3, T4>(Action<T1, T2, T3, T4> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetInterval<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetInterval<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetInterval<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { return 0; }
		[IncludeGenericArguments(false)]
		public int SetInterval<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { return 0; }
		[ExpandParams]
		public int SetInterval(Delegate handler, int timeout, params object[] arguments) { return 0; }
		public int SetInterval(string handler) { return 0; }
		public int SetInterval(string handler, int timeout) { return 0; }

		public void ClearInterval(int handle) {}

		public void ClearTimeout(int handle) {}
	}
}
