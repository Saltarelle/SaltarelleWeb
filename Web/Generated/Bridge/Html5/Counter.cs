namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Counter
	{
		internal extern Counter();

		[FieldProperty]
		public extern string Identifier
		{
			get;
		}

		[FieldProperty]
		public extern string ListStyle
		{
			get;
		}

		[FieldProperty]
		public extern string Separator
		{
			get;
		}
	}
}
