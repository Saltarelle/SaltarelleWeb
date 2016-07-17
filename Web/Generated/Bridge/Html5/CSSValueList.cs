namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class CSSValueList : CSSValue
	{
		internal extern CSSValueList();

		public extern CSSValue this[int index]
		{
			get;
		}

		public extern CSSValue Item(int index);

		public readonly int Length;
	}
}
