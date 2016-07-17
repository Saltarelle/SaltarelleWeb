namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class PluginArray
	{
		internal extern PluginArray();

		public extern Plugin this[int index]
		{
			get;
		}

		public extern Plugin this[string name]
		{
			get;
		}

		public extern Plugin Item(int index);

		public readonly int Length;

		public extern Plugin NamedItem(string name);

		public extern void Refresh();

		public extern void Refresh(bool reloadDocuments);
	}
}
