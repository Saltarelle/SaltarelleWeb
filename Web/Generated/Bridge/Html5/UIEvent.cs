using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class UIEvent : Event
	{
		internal extern UIEvent();

		public extern UIEvent(string type);

		public extern UIEvent(string type, UIEventInit eventInitDict);

		public bool CancelBubble;

		public readonly int Detail;

		public extern void InitUIEvent(string aType, bool aCanBubble, bool aCancelable, WindowInstance aView, int aDetail);

		public readonly bool IsChar;

		public readonly int LayerX;

		public readonly int LayerY;

		public readonly int PageX;

		public readonly int PageY;

		public readonly int RangeOffset;

		public readonly XmlNode RangeParent;

		[Name("SCROLL_PAGE_DOWN")]
		public const int SCROLL_PAGE_DOWN = 32768;

		[Name("SCROLL_PAGE_UP")]
		public const int SCROLL_PAGE_UP = -32768;

		public readonly WindowInstance View;

		public readonly int Which;
	}
}
