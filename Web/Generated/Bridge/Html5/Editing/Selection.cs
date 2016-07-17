using Bridge.Html5.Xml;

namespace Bridge.Html5.Editing
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Selection
	{
		internal extern Selection();

		public extern void AddRange(Range range);

		public readonly XmlNode AnchorNode;

		public readonly int AnchorOffset;

		public extern void Collapse(XmlNode node, int offset);

		public extern void CollapseToEnd();

		public extern void CollapseToStart();

		public extern bool ContainsNode(XmlNode node, bool partlyContained);

		public extern void DeleteFromDocument();

		public extern void Extend(XmlNode node, int offset);

		public readonly XmlNode FocusNode;

		public readonly int FocusOffset;

		public extern Range GetRangeAt(int index);

		public readonly bool IsCollapsed;

		public extern void Modify(string alter, string direction, string granularity);

		public readonly int RangeCount;

		public extern void RemoveAllRanges();

		public extern void RemoveRange(Range range);

		public extern void SelectAllChildren(XmlNode node);
	}
}
