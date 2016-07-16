namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPreserveAspectRatio
	{
		internal extern SVGPreserveAspectRatio();

		[FieldProperty]
		public extern SVGAlign Align
		{
			get;
			set;
		}

		[FieldProperty]
		public extern SVGMeetOrSlice MeetOrSlice
		{
			get;
			set;
		}

		[Name("SVG_MEETORSLICE_MEET")]
		public const ushort SVG_MEETORSLICE_MEET = 1;

		[Name("SVG_MEETORSLICE_SLICE")]
		public const ushort SVG_MEETORSLICE_SLICE = 2;

		[Name("SVG_MEETORSLICE_UNKNOWN")]
		public const ushort SVG_MEETORSLICE_UNKNOWN = 0;

		[Name("SVG_PRESERVEASPECTRATIO_NONE")]
		public const ushort SVG_PRESERVEASPECTRATIO_NONE = 1;

		[Name("SVG_PRESERVEASPECTRATIO_UNKNOWN")]
		public const ushort SVG_PRESERVEASPECTRATIO_UNKNOWN = 0;

		[Name("SVG_PRESERVEASPECTRATIO_XMAXYMAX")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMAXYMAX = 10;

		[Name("SVG_PRESERVEASPECTRATIO_XMAXYMID")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMAXYMID = 7;

		[Name("SVG_PRESERVEASPECTRATIO_XMAXYMIN")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMAXYMIN = 4;

		[Name("SVG_PRESERVEASPECTRATIO_XMIDYMAX")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMIDYMAX = 9;

		[Name("SVG_PRESERVEASPECTRATIO_XMIDYMID")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMIDYMID = 6;

		[Name("SVG_PRESERVEASPECTRATIO_XMIDYMIN")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMIDYMIN = 3;

		[Name("SVG_PRESERVEASPECTRATIO_XMINYMAX")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMINYMAX = 8;

		[Name("SVG_PRESERVEASPECTRATIO_XMINYMID")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMINYMID = 5;

		[Name("SVG_PRESERVEASPECTRATIO_XMINYMIN")]
		public const ushort SVG_PRESERVEASPECTRATIO_XMINYMIN = 2;
	}
}
