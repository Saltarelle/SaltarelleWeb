namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class RGBColor
	{
		internal extern RGBColor();

		[FieldProperty]
		public extern CSSPrimitiveValue Alpha
		{
			get;
		}

		[FieldProperty]
		public extern CSSPrimitiveValue Blue
		{
			get;
		}

		[FieldProperty]
		public extern CSSPrimitiveValue Green
		{
			get;
		}

		[FieldProperty]
		public extern CSSPrimitiveValue Red
		{
			get;
		}
	}
}
