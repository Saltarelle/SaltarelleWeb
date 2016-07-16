using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class UIEvent : Event
	{
		internal UIEvent()
		{
		}

		public UIEvent(string type)
		{
		}

		public UIEvent(string type, UIEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public bool CancelBubble
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public int Detail
		{
			get {
				return 0;
			}
		}

		public void InitUIEvent(string aType, bool aCanBubble, bool aCancelable, WindowInstance aView, int aDetail)
		{
		}

		[FieldProperty]
		public bool IsChar
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public int LayerX
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int LayerY
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int PageX
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int PageY
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int RangeOffset
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public XmlNode RangeParent
		{
			get {
				return default(XmlNode);
			}
		}

		[Name("SCROLL_PAGE_DOWN")]
		public const int SCROLL_PAGE_DOWN = 32768;

		[Name("SCROLL_PAGE_UP")]
		public const int SCROLL_PAGE_UP = -32768;

		[FieldProperty]
		public WindowInstance View
		{
			get {
				return default(WindowInstance);
			}
		}

		[FieldProperty]
		public int Which
		{
			get {
				return 0;
			}
		}
	}
}
