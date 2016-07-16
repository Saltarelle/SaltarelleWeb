namespace Bridge.Html5
{
	[External, Serializable]
	public partial class ConvertCoordinateOptions
	{
		public extern CSSBoxType FromBox
		{
			get;
			set;
		}

		public extern CSSBoxType ToBox
		{
			get;
			set;
		}
	}
}
