namespace Bridge.Html5
{
	[External, Serializable]
	public partial class StyleRuleChangeEventInit : EventInit
	{
		public extern CSSRule Rule
		{
			get;
			set;
		}

		public extern CSSStyleSheet Stylesheet
		{
			get;
			set;
		}
	}
}
