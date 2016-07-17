using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class StyleSheet
	{
		internal extern StyleSheet();

		public bool Disabled;

		public readonly string Href;

		public readonly MediaList Media;

		public readonly XmlNode OwnerNode;

		public readonly StyleSheet ParentStyleSheet;

		public readonly string Title;

		public readonly string Type;
	}
}
