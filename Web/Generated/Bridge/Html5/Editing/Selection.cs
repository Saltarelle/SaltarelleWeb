using Bridge.Html5.Nodes;

namespace Bridge.Html5.Editing
{
	[Namespace(false), External]
	public partial class Selection
	{
		internal extern Selection();

		public extern void AddRange(Range range);

		public readonly Node AnchorNode;

		public readonly int AnchorOffset;

		public extern void Collapse(Node node, int offset);

		public extern void CollapseToEnd();

		public extern void CollapseToStart();

		public extern bool ContainsNode(Node node, bool partlyContained);

		public extern void DeleteFromDocument();

		public extern void Extend(Node node, int offset);

		public readonly Node FocusNode;

		public readonly int FocusOffset;

		public extern Range GetRangeAt(int index);

		public readonly bool IsCollapsed;

		public extern void Modify(string alter, string direction, string granularity);

		public readonly int RangeCount;

		public extern void RemoveAllRanges();

		public extern void RemoveRange(Range range);

		public extern void SelectAllChildren(Node node);
	}
}
