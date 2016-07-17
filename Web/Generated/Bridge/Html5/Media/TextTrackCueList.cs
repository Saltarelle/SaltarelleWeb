using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Media
{
	[Namespace(false), External]
	public partial class TextTrackCueList : IEnumerable<VTTCue>
	{
		internal extern TextTrackCueList();

		public extern VTTCue this[int index]
		{
			get;
		}

		public extern VTTCue GetCueById(string id);

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<VTTCue> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public readonly int Length;
	}
}
