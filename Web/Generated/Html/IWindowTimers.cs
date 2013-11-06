using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported]
	public partial interface IWindowTimers {
		void ClearInterval(int handle);

		void ClearTimeout(int handle);

		int SetInterval(Function handler);

		[ExpandParams]
		int SetInterval(Function handler, int timeout, params object[] arguments);

		int SetInterval(string handler);

		int SetInterval(string handler, int timeout);

		int SetTimeout(Function handler);

		[ExpandParams]
		int SetTimeout(Function handler, int timeout, params object[] arguments);

		int SetTimeout(string handler);

		int SetTimeout(string handler, int timeout);
	}
}
