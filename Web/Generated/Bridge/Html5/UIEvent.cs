using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class UIEvent : Event
	{
		internal extern UIEvent();

		public extern UIEvent(string type);

		public extern UIEvent(string type, UIEventInit eventInitDict);

		[FieldProperty]
		public extern bool CancelBubble
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int Detail
		{
			get;
		}

		public extern void InitUIEvent(string aType, bool aCanBubble, bool aCancelable, WindowInstance aView, int aDetail);

		[FieldProperty]
		public extern bool IsChar
		{
			get;
		}

		[FieldProperty]
		public extern int LayerX
		{
			get;
		}

		[FieldProperty]
		public extern int LayerY
		{
			get;
		}

		[FieldProperty]
		public extern int PageX
		{
			get;
		}

		[FieldProperty]
		public extern int PageY
		{
			get;
		}

		[FieldProperty]
		public extern int RangeOffset
		{
			get;
		}

		[FieldProperty]
		public extern XmlNode RangeParent
		{
			get;
		}

		[Name("SCROLL_PAGE_DOWN")]
		public const int SCROLL_PAGE_DOWN = 32768;

		[Name("SCROLL_PAGE_UP")]
		public const int SCROLL_PAGE_UP = -32768;

		[FieldProperty]
		public extern WindowInstance View
		{
			get;
		}

		[FieldProperty]
		public extern int Which
		{
			get;
		}
	}
}
