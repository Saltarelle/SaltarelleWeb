namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class VTTRegion
	{
		public extern VTTRegion();

		[FieldProperty]
		public extern int Lines
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double RegionAnchorX
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double RegionAnchorY
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Scroll
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double ViewportAnchorX
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double ViewportAnchorY
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Width
		{
			get;
			set;
		}
	}
}
