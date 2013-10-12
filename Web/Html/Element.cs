using System.Runtime.CompilerServices;

namespace System.Html {
	public partial class Element {
		[ScriptSkip]
		public TElement As<TElement>() where TElement : Element {
			return null;
		}

		[ScriptName("id"), Obsolete("Use property Id instead")]
		public string ID { get; set; }
	}
}