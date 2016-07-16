namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class BarProp
	{
		internal BarProp()
		{
		}

		[FieldProperty]
		public bool Visible
		{
			get {
				return false;
			}
			set {
			}
		}
	}
}
