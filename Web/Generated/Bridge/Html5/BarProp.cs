namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class BarProp
	{
		internal extern BarProp();

		[FieldProperty]
		public extern bool Visible
		{
			get;
			set;
		}
	}
}
