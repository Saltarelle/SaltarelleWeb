using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class StyleSheet
	{
		internal StyleSheet()
		{
		}

		[FieldProperty]
		public bool Disabled
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public string Href
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public MediaList Media
		{
			get {
				return default(MediaList);
			}
		}

		[FieldProperty]
		public XmlNode OwnerNode
		{
			get {
				return default(XmlNode);
			}
		}

		[FieldProperty]
		public StyleSheet ParentStyleSheet
		{
			get {
				return default(StyleSheet);
			}
		}

		[FieldProperty]
		public string Title
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string Type
		{
			get {
				return null;
			}
		}
	}
}
