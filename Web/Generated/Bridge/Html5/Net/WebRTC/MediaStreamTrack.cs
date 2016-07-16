namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MediaStreamTrack
	{
		internal extern MediaStreamTrack();

		[FieldProperty]
		public extern bool Enabled
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Id
		{
			get;
		}

		[FieldProperty]
		public extern string Kind
		{
			get;
		}

		[FieldProperty]
		public extern string Label
		{
			get;
		}
	}
}
