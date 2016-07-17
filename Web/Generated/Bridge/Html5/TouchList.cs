namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class TouchList
	{
		internal extern TouchList();

		public extern Touch this[int index]
		{
			get;
		}

		public extern Touch IdentifiedTouch(int identifier);

		public extern Touch Item(int index);

		public readonly int Length;
	}
}
