using Bridge.Html5.Elements;
using Bridge.Html5.Nodes;

namespace Bridge.Html5.Editing
{
	[Namespace(false), External]
	public partial class Range
	{
		public extern Range();

		public extern DocumentFragment CloneContents();

		public extern Range CloneRange();

		public extern void Collapse();

		public extern void Collapse(bool toStart);

		public readonly bool Collapsed;

		public readonly Node CommonAncestorContainer;

		public extern short CompareBoundaryPoints(RangeComparison how, Range sourceRange);

		public extern short ComparePoint(Node node, int offset);

		public extern DocumentFragment CreateContextualFragment(string fragment);

		public extern void DeleteContents();

		public extern void Detach();

		[Name("END_TO_END")]
		public const ushort END_TO_END = 2;

		[Name("END_TO_START")]
		public const ushort END_TO_START = 3;

		public readonly Node EndContainer;

		public readonly int EndOffset;

		public extern DocumentFragment ExtractContents();

		public extern DOMRect GetBoundingClientRect();

		public extern DOMRectList GetClientRects();

		public extern void InsertNode(Node node);

		public extern bool IntersectsNode(Node node);

		public extern bool IsPointInRange(Node node, int offset);

		public extern void SelectNode(Node refNode);

		public extern void SelectNodeContents(Node refNode);

		public extern void SetEnd(Node refNode, int offset);

		public extern void SetEndAfter(Node refNode);

		public extern void SetEndBefore(Node refNode);

		public extern void SetStart(Node refNode, int offset);

		public extern void SetStartAfter(Node refNode);

		public extern void SetStartBefore(Node refNode);

		[Name("START_TO_END")]
		public const ushort START_TO_END = 1;

		[Name("START_TO_START")]
		public const ushort START_TO_START = 0;

		public readonly Node StartContainer;

		public readonly int StartOffset;

		public extern void SurroundContents(Node newParent);
	}
}
