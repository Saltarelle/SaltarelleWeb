namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMPointReadOnly
	{
		internal extern DOMPointReadOnly();

		[FieldProperty]
		public extern double W
		{
			get;
		}

		[FieldProperty]
		public extern double X
		{
			get;
		}

		[FieldProperty]
		public extern double Y
		{
			get;
		}

		[FieldProperty]
		public extern double Z
		{
			get;
		}
	}
}
