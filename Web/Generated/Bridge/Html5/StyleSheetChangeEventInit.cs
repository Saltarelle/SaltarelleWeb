namespace Bridge.Html5
{
	[External, Serializable]
	public partial class StyleSheetChangeEventInit : EventInit
	{
		public bool DocumentSheet;

		public CSSStyleSheet Stylesheet;
	}
}
