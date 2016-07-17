namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class DOMStringList
	{
		internal extern DOMStringList();

		public extern string this[int index]
		{
			get;
		}

		public extern bool Contains(string @string);

		public extern string Item(int index);

		public readonly int Length;
	}
}
