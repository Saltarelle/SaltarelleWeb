using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CaretPosition
	{
		internal extern CaretPosition();

		public extern DOMRect GetClientRect();

		[FieldProperty]
		public extern int Offset
		{
			get;
		}

		[FieldProperty]
		public extern XmlNode OffsetNode
		{
			get;
		}
	}
}
