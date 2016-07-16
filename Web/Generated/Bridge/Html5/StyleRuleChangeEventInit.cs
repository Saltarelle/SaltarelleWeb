namespace Bridge.Html5
{
	[External, Serializable]
	public partial class StyleRuleChangeEventInit : EventInit
	{
		public CSSRule Rule
		{
			get;
			set;
		}

		public CSSStyleSheet Stylesheet
		{
			get;
			set;
		}
	}
}
