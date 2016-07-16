namespace Bridge.Html5.WebComponents
{
	[External, Serializable]
	public partial class ElementRegistrationOptions
	{
		public extern string Extends
		{
			get;
			set;
		}

		public extern object Prototype
		{
			get;
			set;
		}
	}
}
