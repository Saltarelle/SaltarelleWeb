using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Graphics
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ImageData
	{
		internal ImageData()
		{
		}

		public ImageData(int sw, int sh)
		{
		}

		public ImageData(Uint8ClampedArray data, int sw)
		{
		}

		public ImageData(Uint8ClampedArray data, int sw, int sh)
		{
		}

		[FieldProperty]
		public Uint8ClampedArray Data
		{
			get {
				return default(Uint8ClampedArray);
			}
		}

		[FieldProperty]
		public int Height
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int Width
		{
			get {
				return 0;
			}
		}
	}
}
