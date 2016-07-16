namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMSettableTokenList : TokenList
	{
		internal extern DOMSettableTokenList();

		[FieldProperty]
		public extern string Value
		{
			get;
			set;
		}
	}
}
