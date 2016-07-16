namespace Bridge.Html5.Net.ServerEvents
{
	[External, Serializable]
	public partial class EventSourceInit
	{
		public extern bool WithCredentials
		{
			get;
			set;
		}
	}
}
