using System;

namespace Bridge.Html5.Media
{
	[External, Serializable]
	public partial class MediaStreamConstraints
	{
		public TypeOption<bool, object> Audio;

		public bool Fake;

		public bool Picture;

		public TypeOption<bool, object> Video;
	}
}
