using System.Runtime.CompilerServices;

namespace System.Html.WebComponents {
	[Imported, Serializable]
	public partial class ElementRegistrationOptions {
		public string Extends {
			get;
			set;
		}

		public object Prototype {
			get;
			set;
		}
	}
}
