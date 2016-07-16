using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class StyleSheet
	{
		internal extern StyleSheet();

		[FieldProperty]
		public extern bool Disabled
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Href
		{
			get;
		}

		[FieldProperty]
		public extern MediaList Media
		{
			get;
		}

		[FieldProperty]
		public extern XmlNode OwnerNode
		{
			get;
		}

		[FieldProperty]
		public extern StyleSheet ParentStyleSheet
		{
			get;
		}

		[FieldProperty]
		public extern string Title
		{
			get;
		}

		[FieldProperty]
		public extern string Type
		{
			get;
		}
	}
}
