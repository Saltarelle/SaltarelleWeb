// Range.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html.Editing {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class Range {
		public Range() {
		}

		public XmlDocumentFragment CloneContents() {
			return default(XmlDocumentFragment);
		}

		public Range CloneRange() {
			return default(Range);
		}

		public void Collapse() {
		}

		public void Collapse(bool toStart) {
		}

		[IntrinsicProperty]
		public bool Collapsed {
			get { return false; }
		}

		[IntrinsicProperty]
		public XmlNode CommonAncestorContainer {
			get { return default(XmlNode); }
		}

		public short CompareBoundaryPoints(RangeComparison how, Range sourceRange) {
			return 0;
		}

		public short ComparePoint(XmlNode node, uint offset) {
			return 0;
		}

		public XmlDocumentFragment CreateContextualFragment(string fragment) {
			return default(XmlDocumentFragment);
		}

		public void DeleteContents() {
		}

		public void Detach() {
		}

		[ScriptName("END_TO_END")]
		public const ushort END_TO_END = 2;

		[ScriptName("END_TO_START")]
		public const ushort END_TO_START = 3;

		[IntrinsicProperty]
		public XmlNode EndContainer {
			get { return default(XmlNode); }
		}

		[IntrinsicProperty]
		public uint EndOffset {
			get { return 0; }
		}

		public XmlDocumentFragment ExtractContents() {
			return default(XmlDocumentFragment);
		}

		public ClientRect GetBoundingClientRect() {
			return default(ClientRect);
		}

		public ClientRectList GetClientRects() {
			return default(ClientRectList);
		}

		public void InsertNode(XmlNode node) {
		}

		public bool IntersectsNode(XmlNode node) {
			return false;
		}

		public bool IsPointInRange(XmlNode node, uint offset) {
			return false;
		}

		public void SelectNode(XmlNode refNode) {
		}

		public void SelectNodeContents(XmlNode refNode) {
		}

		public void SetEnd(XmlNode refNode, uint offset) {
		}

		public void SetEndAfter(XmlNode refNode) {
		}

		public void SetEndBefore(XmlNode refNode) {
		}

		public void SetStart(XmlNode refNode, uint offset) {
		}

		public void SetStartAfter(XmlNode refNode) {
		}

		public void SetStartBefore(XmlNode refNode) {
		}

		[ScriptName("START_TO_END")]
		public const ushort START_TO_END = 1;

		[ScriptName("START_TO_START")]
		public const ushort START_TO_START = 0;

		[IntrinsicProperty]
		public XmlNode StartContainer {
			get { return default(XmlNode); }
		}

		[IntrinsicProperty]
		public uint StartOffset {
			get { return 0; }
		}

		public void SurroundContents(XmlNode newParent) {
		}
	}
}
