// SVGComponentTransferFunctionElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGComponentTransferFunctionElement : SVGElement {
		internal SVGComponentTransferFunctionElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber Amplitude {
			get { return default(SVGAnimatedNumber); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber Exponent {
			get { return default(SVGAnimatedNumber); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber Intercept {
			get { return default(SVGAnimatedNumber); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber Offset {
			get { return default(SVGAnimatedNumber); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber Slope {
			get { return default(SVGAnimatedNumber); }
		}

		[ScriptName("SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE")]
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE = 3;

		[ScriptName("SVG_FECOMPONENTTRANSFER_TYPE_GAMMA")]
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_GAMMA = 5;

		[ScriptName("SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY")]
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY = 1;

		[ScriptName("SVG_FECOMPONENTTRANSFER_TYPE_LINEAR")]
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_LINEAR = 4;

		[ScriptName("SVG_FECOMPONENTTRANSFER_TYPE_TABLE")]
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_TABLE = 2;

		[ScriptName("SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN")]
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN = 0;

		[IntrinsicProperty]
		public SVGAnimatedNumberList TableValues {
			get { return default(SVGAnimatedNumberList); }
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGComponentTransferType> Type {
			get { return default(SVGAnimatedEnumeration<SVGComponentTransferType>); }
		}
	}
}
