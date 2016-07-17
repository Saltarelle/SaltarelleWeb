namespace Bridge.Html5
{
	[External, Serializable]
	public partial class StyleRuleChangeEventInit : EventInit
	{
		public CSSRule Rule;

		public CSSStyleSheet Stylesheet;
	}
}
