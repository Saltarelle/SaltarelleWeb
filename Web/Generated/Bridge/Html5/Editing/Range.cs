﻿using Bridge.Html5.Xml;

namespace Bridge.Html5.Editing
{
	[Namespace("false"), External]
	public partial class Range
	{
		public extern Range();

		public extern XmlDocumentFragment CloneContents();

		public extern Range CloneRange();

		public extern void Collapse();

		public extern void Collapse(bool toStart);

		public readonly bool Collapsed;

		public readonly XmlNode CommonAncestorContainer;

		public extern short CompareBoundaryPoints(RangeComparison how, Range sourceRange);

		public extern short ComparePoint(XmlNode node, int offset);

		public extern XmlDocumentFragment CreateContextualFragment(string fragment);

		public extern void DeleteContents();

		public extern void Detach();

		[Name("END_TO_END")]
		public const ushort END_TO_END = 2;

		[Name("END_TO_START")]
		public const ushort END_TO_START = 3;

		public readonly XmlNode EndContainer;

		public readonly int EndOffset;

		public extern XmlDocumentFragment ExtractContents();

		public extern DOMRect GetBoundingClientRect();

		public extern DOMRectList GetClientRects();

		public extern void InsertNode(XmlNode node);

		public extern bool IntersectsNode(XmlNode node);

		public extern bool IsPointInRange(XmlNode node, int offset);

		public extern void SelectNode(XmlNode refNode);

		public extern void SelectNodeContents(XmlNode refNode);

		public extern void SetEnd(XmlNode refNode, int offset);

		public extern void SetEndAfter(XmlNode refNode);

		public extern void SetEndBefore(XmlNode refNode);

		public extern void SetStart(XmlNode refNode, int offset);

		public extern void SetStartAfter(XmlNode refNode);

		public extern void SetStartBefore(XmlNode refNode);

		[Name("START_TO_END")]
		public const ushort START_TO_END = 1;

		[Name("START_TO_START")]
		public const ushort START_TO_START = 0;

		public readonly XmlNode StartContainer;

		public readonly int StartOffset;

		public extern void SurroundContents(XmlNode newParent);
	}
}
