namespace Bridge.Html5.WebComponents
{
	[External, Serializable]
	public partial class LifecycleCallbacks
	{
		public extern LifecycleAttachedCallback AttachedCallback
		{
			get;
			set;
		}

		public extern LifecycleAttributeChangedCallback AttributeChangedCallback
		{
			get;
			set;
		}

		public extern LifecycleCreatedCallback CreatedCallback
		{
			get;
			set;
		}

		public extern LifecycleDetachedCallback DetachedCallback
		{
			get;
			set;
		}
	}
}
