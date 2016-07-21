using Bridge.Html5.Nodes;

namespace Bridge.Html5.CSS
{
	[Namespace(false), External]
	public partial class StyleSheet
	{
		internal extern StyleSheet();

		public bool Disabled;

		public readonly string Href;

		public readonly MediaList Media;

		public readonly Node OwnerNode;

		public readonly StyleSheet ParentStyleSheet;

		public readonly string Title;

		public readonly string Type;
	}
}
