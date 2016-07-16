namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CSSStyleSheet : StyleSheet
	{
		internal extern CSSStyleSheet();

		[FieldProperty]
		public extern CSSRule[] CssRules
		{
			get;
		}

		public extern void DeleteRule(int index);

		public extern int InsertRule(string rule, int index);

		[FieldProperty]
		public extern CSSRule OwnerRule
		{
			get;
		}
	}
}
