namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CSSStyleSheet : StyleSheet
	{
		internal CSSStyleSheet()
		{
		}

		[FieldProperty]
		public CSSRule[] CssRules
		{
			get {
				return null;
			}
		}

		public void DeleteRule(int index)
		{
		}

		public int InsertRule(string rule, int index)
		{
			return 0;
		}

		[FieldProperty]
		public CSSRule OwnerRule
		{
			get {
				return default(CSSRule);
			}
		}
	}
}
