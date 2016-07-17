namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class DOMQuad
	{
		public extern DOMQuad();

		public extern DOMQuad(DOMPointInit p1);

		public extern DOMQuad(DOMPointInit p1, DOMPointInit p2);

		public extern DOMQuad(DOMPointInit p1, DOMPointInit p2, DOMPointInit p3);

		public extern DOMQuad(DOMPointInit p1, DOMPointInit p2, DOMPointInit p3, DOMPointInit p4);

		public extern DOMQuad(DOMRectReadOnly rect);

		public readonly DOMRectReadOnly Bounds;

		public readonly DOMPoint P1;

		public readonly DOMPoint P2;

		public readonly DOMPoint P3;

		public readonly DOMPoint P4;
	}
}
