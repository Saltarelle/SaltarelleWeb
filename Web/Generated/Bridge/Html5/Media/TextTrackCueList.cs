using System.Collections.Generic;

namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TextTrackCueList
	{
		internal TextTrackCueList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public VTTCue this[int index]
		{
			get {
				return default(VTTCue);
			}
		}

		public VTTCue GetCueById(string id)
		{
			return default(VTTCue);
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<VTTCue> GetEnumerator()
		{
			return null;
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}
	}
}
