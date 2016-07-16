namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMRect : DOMRectReadOnly
	{
		public extern DOMRect();

		public extern DOMRect(double x, double y, double width, double height);

		[FieldProperty]
		public extern double Height
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

		[FieldProperty]
		public extern double X
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Y
		{
			get;
			set;
		}
	}
}
