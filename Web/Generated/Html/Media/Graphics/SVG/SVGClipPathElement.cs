// SVGClipPathElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGClipPathElement : SVGElement {
		internal SVGClipPathElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGUnitType> ClipPathUnits {
			get { return default(SVGAnimatedEnumeration<SVGUnitType>); }
		}

		[ScriptName("SVG_UNIT_TYPE_OBJECTBOUNDINGBOX")]
		public const ushort SVG_UNIT_TYPE_OBJECTBOUNDINGBOX = 2;

		[ScriptName("SVG_UNIT_TYPE_UNKNOWN")]
		public const ushort SVG_UNIT_TYPE_UNKNOWN = 0;

		[ScriptName("SVG_UNIT_TYPE_USERSPACEONUSE")]
		public const ushort SVG_UNIT_TYPE_USERSPACEONUSE = 1;

		[IntrinsicProperty]
		public SVGAnimatedTransformList Transform {
			get { return default(SVGAnimatedTransformList); }
		}
	}
}
