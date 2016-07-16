namespace Bridge.Html5.Media
{
	[External, Serializable]
	public partial class MediaStreamEventInit : EventInit
	{
		public extern MediaStream Stream
		{
			get;
			set;
		}
	}
}
