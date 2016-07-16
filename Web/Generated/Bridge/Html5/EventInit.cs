namespace Bridge.Html5
{
	[External, Serializable]
	public partial class EventInit
	{
		public extern bool Bubbles
		{
			get;
			set;
		}

		public extern bool Cancelable
		{
			get;
			set;
		}
	}
}
