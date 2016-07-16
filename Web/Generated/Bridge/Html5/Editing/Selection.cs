using Bridge.Html5.Xml;

namespace Bridge.Html5.Editing
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Selection
	{
		internal extern Selection();

		public extern void AddRange(Range range);

		[FieldProperty]
		public extern XmlNode AnchorNode
		{
			get;
		}

		[FieldProperty]
		public extern int AnchorOffset
		{
			get;
		}

		public extern void Collapse(XmlNode node, int offset);

		public extern void CollapseToEnd();

		public extern void CollapseToStart();

		public extern bool ContainsNode(XmlNode node, bool partlyContained);

		public extern void DeleteFromDocument();

		public extern void Extend(XmlNode node, int offset);

		[FieldProperty]
		public extern XmlNode FocusNode
		{
			get;
		}

		[FieldProperty]
		public extern int FocusOffset
		{
			get;
		}

		public extern Range GetRangeAt(int index);

		[FieldProperty]
		public extern bool IsCollapsed
		{
			get;
		}

		public extern void Modify(string alter, string direction, string granularity);

		[FieldProperty]
		public extern int RangeCount
		{
			get;
		}

		public extern void RemoveAllRanges();

		public extern void RemoveRange(Range range);

		public extern void SelectAllChildren(XmlNode node);
	}
}
