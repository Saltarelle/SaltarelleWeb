using System;

namespace Bridge.Html5.Media
{
	[External, Serializable]
	public partial class MediaStreamConstraints
	{
		public extern TypeOption<bool, object> Audio
		{
			get;
			set;
		}

		public extern bool Fake
		{
			get;
			set;
		}

		public extern bool Picture
		{
			get;
			set;
		}

		public extern TypeOption<bool, object> Video
		{
			get;
			set;
		}
	}
}
