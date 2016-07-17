namespace Bridge.Html5
{
	[External, Serializable]
	public partial class StyleSheetApplicableStateChangeEventInit : EventInit
	{
		public bool Applicable;

		public CSSStyleSheet Stylesheet;
	}
}
