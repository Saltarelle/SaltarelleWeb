using Bridge.Html5.Xml;

namespace Bridge.Html5.Editing
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Range
	{
		public Range()
		{
		}

		public XmlDocumentFragment CloneContents()
		{
			return default(XmlDocumentFragment);
		}

		public Range CloneRange()
		{
			return default(Range);
		}

		public void Collapse()
		{
		}

		public void Collapse(bool toStart)
		{
		}

		[FieldProperty]
		public bool Collapsed
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public XmlNode CommonAncestorContainer
		{
			get {
				return default(XmlNode);
			}
		}

		public short CompareBoundaryPoints(RangeComparison how, Range sourceRange)
		{
			return 0;
		}

		public short ComparePoint(XmlNode node, int offset)
		{
			return 0;
		}

		public XmlDocumentFragment CreateContextualFragment(string fragment)
		{
			return default(XmlDocumentFragment);
		}

		public void DeleteContents()
		{
		}

		public void Detach()
		{
		}

		[Name("END_TO_END")]
		public const ushort END_TO_END = 2;

		[Name("END_TO_START")]
		public const ushort END_TO_START = 3;

		[FieldProperty]
		public XmlNode EndContainer
		{
			get {
				return default(XmlNode);
			}
		}

		[FieldProperty]
		public int EndOffset
		{
			get {
				return 0;
			}
		}

		public XmlDocumentFragment ExtractContents()
		{
			return default(XmlDocumentFragment);
		}

		public DOMRect GetBoundingClientRect()
		{
			return default(DOMRect);
		}

		public DOMRectList GetClientRects()
		{
			return default(DOMRectList);
		}

		public void InsertNode(XmlNode node)
		{
		}

		public bool IntersectsNode(XmlNode node)
		{
			return false;
		}

		public bool IsPointInRange(XmlNode node, int offset)
		{
			return false;
		}

		public void SelectNode(XmlNode refNode)
		{
		}

		public void SelectNodeContents(XmlNode refNode)
		{
		}

		public void SetEnd(XmlNode refNode, int offset)
		{
		}

		public void SetEndAfter(XmlNode refNode)
		{
		}

		public void SetEndBefore(XmlNode refNode)
		{
		}

		public void SetStart(XmlNode refNode, int offset)
		{
		}

		public void SetStartAfter(XmlNode refNode)
		{
		}

		public void SetStartBefore(XmlNode refNode)
		{
		}

		[Name("START_TO_END")]
		public const ushort START_TO_END = 1;

		[Name("START_TO_START")]
		public const ushort START_TO_START = 0;

		[FieldProperty]
		public XmlNode StartContainer
		{
			get {
				return default(XmlNode);
			}
		}

		[FieldProperty]
		public int StartOffset
		{
			get {
				return 0;
			}
		}

		public void SurroundContents(XmlNode newParent)
		{
		}
	}
}
