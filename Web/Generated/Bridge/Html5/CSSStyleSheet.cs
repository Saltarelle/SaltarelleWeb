namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class CSSStyleSheet : StyleSheet
	{
		internal extern CSSStyleSheet();

		public readonly CSSRule[] CssRules;

		public extern void DeleteRule(int index);

		public extern int InsertRule(string rule, int index);

		public readonly CSSRule OwnerRule;
	}
}
