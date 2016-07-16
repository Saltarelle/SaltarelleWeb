namespace Bridge.Html5.WebComponents
{
	[External, Serializable]
	public partial class ElementReplaceEventInit : EventInit
	{
		public extern Element Upgrade
		{
			get;
			set;
		}
	}
}
