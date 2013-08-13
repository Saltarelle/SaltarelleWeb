using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class MutationObserverInit {
		public string[] AttributeFilter {
			get;
			set;
		}

		public bool AttributeOldValue {
			get;
			set;
		}

		public bool Attributes {
			get;
			set;
		}

		public bool CharacterData {
			get;
			set;
		}

		public bool CharacterDataOldValue {
			get;
			set;
		}

		public bool ChildList {
			get;
			set;
		}

		public bool Subtree {
			get;
			set;
		}
	}
}
