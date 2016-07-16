namespace Bridge.Html5
{
	[External, Serializable]
	public partial class StyleSheetApplicableStateChangeEventInit : EventInit
	{
		public extern bool Applicable
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
