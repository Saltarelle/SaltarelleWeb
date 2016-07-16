namespace Bridge.Html5.Media
{
	[External, Serializable]
	public partial class MediaStreamEventInit : EventInit
	{
		public MediaStream Stream
		{
			get;
			set;
		}
	}
}
