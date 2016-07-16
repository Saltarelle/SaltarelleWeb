namespace Bridge.Html5
{
	[External, Serializable]
	public partial class StyleSheetChangeEventInit : EventInit
	{
		public bool DocumentSheet
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
