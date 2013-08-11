// SVGPreserveAspectRatio.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPreserveAspectRatio {
		internal SVGPreserveAspectRatio() {
		}

		[IntrinsicProperty]
		public SVGAlign Align {
			get { return default(SVGAlign); }
			set { }
		}

		[IntrinsicProperty]
		public SVGMeetOrSlice MeetOrSlice {
			get { return default(SVGMeetOrSlice); }
			set { }
		}

		[ScriptName("SVG_MEETORSLICE_MEET")]
		public const ushort SVG_MEETORSLICE_MEET = 1;

		[ScriptName("SVG_MEETORSLICE_SLICE")]
		public const ushort SVG_MEETORSLICE_SLICE = 2;

		[ScriptName("SVG_MEETORSLICE_UNKNOWN")]
		public const ushort SVG_MEETORSLICE_UNKNOWN = 0;

		[ScriptName("SVG_PRESERVEASPECTRATIO_NONE")]
		public const ushort SVG_PRESERVEASPECTRATIO_NONE = 1;

		[ScriptName("SVG_PRESERVEASPECTRATIO_UNKNOWN")]
		public const ushort SVG_PRESERVEASPECTRATIO_UNKNOWN = 0;

		[ScriptName("SVG_PRESERVEASPECTRATIO_XMAXYMAX")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMAXYMAX = 10;

		[ScriptName("SVG_PRESERVEASPECTRATIO_XMAXYMID")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMAXYMID = 7;

		[ScriptName("SVG_PRESERVEASPECTRATIO_XMAXYMIN")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMAXYMIN = 4;

		[ScriptName("SVG_PRESERVEASPECTRATIO_XMIDYMAX")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMIDYMAX = 9;

		[ScriptName("SVG_PRESERVEASPECTRATIO_XMIDYMID")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMIDYMID = 6;

		[ScriptName("SVG_PRESERVEASPECTRATIO_XMIDYMIN")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMIDYMIN = 3;

		[ScriptName("SVG_PRESERVEASPECTRATIO_XMINYMAX")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMINYMAX = 8;

		[ScriptName("SVG_PRESERVEASPECTRATIO_XMINYMID")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMINYMID = 5;

		[ScriptName("SVG_PRESERVEASPECTRATIO_XMINYMIN")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMINYMIN = 2;
	}
}
