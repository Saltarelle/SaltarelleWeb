using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioBuffer
	{
		internal extern AudioBuffer();

		public extern void CopyFromChannel(Float32Array destination, int channelNumber);

		public extern void CopyFromChannel(Float32Array destination, int channelNumber, int startInChannel);

		public extern void CopyToChannel(Float32Array source, int channelNumber);

		public extern void CopyToChannel(Float32Array source, int channelNumber, int startInChannel);

		public readonly double Duration;

		public extern Float32Array GetChannelData(int channel);

		public readonly int Length;

		public readonly int NumberOfChannels;

		public readonly double SampleRate;
	}
}
