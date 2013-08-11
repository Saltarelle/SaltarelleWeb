// SVGPathSegArcAbs.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPathSegArcAbs : SVGPathSeg {
		internal SVGPathSegArcAbs() {
		}

		[IntrinsicProperty]
		public float Angle {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public bool LargeArcFlag {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public float R1 {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public float R2 {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public bool SweepFlag {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public float X {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public float Y {
			get { return 0; }
			set { }
		}
	}
}
