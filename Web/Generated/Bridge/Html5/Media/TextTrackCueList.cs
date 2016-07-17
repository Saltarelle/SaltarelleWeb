namespace Bridge.Html5.Media
{
	[Namespace("false"), External]
	public partial class TextTrackCueList
	{
		internal extern TextTrackCueList();

		public extern VTTCue this[int index]
		{
			get;
		}

		public extern VTTCue GetCueById(string id);

		public readonly int Length;
	}
}
