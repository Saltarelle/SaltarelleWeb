namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Rect
	{
		internal extern Rect();

		[FieldProperty]
		public extern CSSPrimitiveValue Bottom
		{
			get;
		}

		[FieldProperty]
		public extern CSSPrimitiveValue Left
		{
			get;
		}

		[FieldProperty]
		public extern CSSPrimitiveValue Right
		{
			get;
		}

		[FieldProperty]
		public extern CSSPrimitiveValue Top
		{
			get;
		}
	}
}
