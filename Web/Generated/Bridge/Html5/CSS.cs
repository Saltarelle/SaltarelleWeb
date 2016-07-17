namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class CSS
	{
		internal extern CSS();

		public static extern string Escape(string ident);

		public static extern bool Supports(string conditionText);

		public static extern bool Supports(string property, string value);
	}
}
