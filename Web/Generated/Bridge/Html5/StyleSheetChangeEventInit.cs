namespace Bridge.Html5
{
	[External, Serializable]
	public partial class StyleSheetChangeEventInit : EventInit
	{
		public extern bool DocumentSheet
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
