namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class DOMRect : DOMRectReadOnly
	{
		public extern DOMRect();

		public extern DOMRect(double x, double y, double width, double height);

		public double Height;

		public double Width;

		public double X;

		public double Y;
	}
}
