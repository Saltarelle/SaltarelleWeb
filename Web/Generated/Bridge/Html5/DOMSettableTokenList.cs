namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMSettableTokenList : TokenList
	{
		internal DOMSettableTokenList()
		{
		}

		[FieldProperty]
		public string Value
		{
			get {
				return null;
			}
			set {
			}
		}
	}
}
