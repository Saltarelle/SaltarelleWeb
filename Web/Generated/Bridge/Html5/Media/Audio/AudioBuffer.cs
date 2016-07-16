using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioBuffer
	{
		internal AudioBuffer()
		{
		}

		public void CopyFromChannel(Float32Array destination, int channelNumber)
		{
		}

		public void CopyFromChannel(Float32Array destination, int channelNumber, int startInChannel)
		{
		}

		public void CopyToChannel(Float32Array source, int channelNumber)
		{
		}

		public void CopyToChannel(Float32Array source, int channelNumber, int startInChannel)
		{
		}

		[FieldProperty]
		public double Duration
		{
			get {
				return 0;
			}
		}

		public Float32Array GetChannelData(int channel)
		{
			return default(Float32Array);
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int NumberOfChannels
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double SampleRate
		{
			get {
				return 0;
			}
		}
	}
}
