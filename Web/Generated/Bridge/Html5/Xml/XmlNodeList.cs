namespace Bridge.Html5.Xml
{
	[Namespace("false"), External, Name("NodeList")]
	public partial class XmlNodeList
	{
		internal extern XmlNodeList();

		public extern XmlNode this[int index]
		{
			get;
		}

		public extern XmlNode Item(int index);

		public readonly int Length;
	}
}
