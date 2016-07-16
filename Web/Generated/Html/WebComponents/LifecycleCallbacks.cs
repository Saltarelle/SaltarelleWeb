using System.Runtime.CompilerServices;

namespace System.Html.WebComponents {
	[Imported, Serializable]
	public partial class LifecycleCallbacks {
		public LifecycleAttachedCallback AttachedCallback {
			get;
			set;
		}

		public LifecycleAttributeChangedCallback AttributeChangedCallback {
			get;
			set;
		}

		public LifecycleCreatedCallback CreatedCallback {
			get;
			set;
		}

		public LifecycleDetachedCallback DetachedCallback {
			get;
			set;
		}
	}
}
