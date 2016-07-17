using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Graphics
{
	[Namespace("false"), External]
	public partial class ImageData
	{
		internal extern ImageData();

		public extern ImageData(int sw, int sh);

		public extern ImageData(Uint8ClampedArray data, int sw);

		public extern ImageData(Uint8ClampedArray data, int sw, int sh);

		public readonly Uint8ClampedArray Data;

		public readonly int Height;

		public readonly int Width;
	}
}
