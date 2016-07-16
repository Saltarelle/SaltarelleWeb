namespace Bridge.Html5.WebComponents
{
	[External, Serializable]
	public partial class LifecycleCallbacks
	{
		public LifecycleAttachedCallback AttachedCallback
		{
			get;
			set;
		}

		public LifecycleAttributeChangedCallback AttributeChangedCallback
		{
			get;
			set;
		}

		public LifecycleCreatedCallback CreatedCallback
		{
			get;
			set;
		}

		public LifecycleDetachedCallback DetachedCallback
		{
			get;
			set;
		}
	}
}
