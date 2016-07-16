using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CaretPosition
	{
		internal CaretPosition()
		{
		}

		public DOMRect GetClientRect()
		{
			return default(DOMRect);
		}

		[FieldProperty]
		public int Offset
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public XmlNode OffsetNode
		{
			get {
				return default(XmlNode);
			}
		}
	}
}
