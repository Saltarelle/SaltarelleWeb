// SVGTransformList.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGTransformList {
		internal SVGTransformList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SVGTransform this[uint index] {
			get { return default(SVGTransform); }
		}

		public SVGTransform AppendItem(SVGTransform newItem) {
			return default(SVGTransform);
		}

		public void Clear() {
		}

		public SVGTransform Consolidate() {
			return default(SVGTransform);
		}

		public SVGTransform CreateSVGTransformFromMatrix(SVGMatrix matrix) {
			return default(SVGTransform);
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SVGTransform> GetEnumerator() {
			return default(IEnumerator<SVGTransform>);
		}

		public SVGTransform GetItem(uint index) {
			return default(SVGTransform);
		}

		public SVGTransform Initialize(SVGTransform newItem) {
			return default(SVGTransform);
		}

		public SVGTransform InsertItemBefore(SVGTransform newItem, uint index) {
			return default(SVGTransform);
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}

		[IntrinsicProperty]
		public uint NumberOfItems {
			get { return 0; }
		}

		public SVGTransform RemoveItem(uint index) {
			return default(SVGTransform);
		}

		public SVGTransform ReplaceItem(SVGTransform newItem, uint index) {
			return default(SVGTransform);
		}
	}
}
