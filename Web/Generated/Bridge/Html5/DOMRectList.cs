namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class DOMRectList
	{
		internal extern DOMRectList();

		public extern DOMRect this[int index]
		{
			get;
		}

		public extern DOMRect Item(int index);

		public readonly int Length;
	}
}
