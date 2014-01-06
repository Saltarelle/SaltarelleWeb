using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported]
	public partial interface IWindowTimers {
		void ClearInterval(int handle);

		void ClearTimeout(int handle);
	}
}
