namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMQuad
	{
		public extern DOMQuad();

		public extern DOMQuad(DOMPointInit p1);

		public extern DOMQuad(DOMPointInit p1, DOMPointInit p2);

		public extern DOMQuad(DOMPointInit p1, DOMPointInit p2, DOMPointInit p3);

		public extern DOMQuad(DOMPointInit p1, DOMPointInit p2, DOMPointInit p3, DOMPointInit p4);

		public extern DOMQuad(DOMRectReadOnly rect);

		[FieldProperty]
		public extern DOMRectReadOnly Bounds
		{
			get;
		}

		[FieldProperty]
		public extern DOMPoint P1
		{
			get;
		}

		[FieldProperty]
		public extern DOMPoint P2
		{
			get;
		}

		[FieldProperty]
		public extern DOMPoint P3
		{
			get;
		}

		[FieldProperty]
		public extern DOMPoint P4
		{
			get;
		}
	}
}
