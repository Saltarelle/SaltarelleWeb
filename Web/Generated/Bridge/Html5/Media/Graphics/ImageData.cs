using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Graphics
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ImageData
	{
		internal extern ImageData();

		public extern ImageData(int sw, int sh);

		public extern ImageData(Uint8ClampedArray data, int sw);

		public extern ImageData(Uint8ClampedArray data, int sw, int sh);

		[FieldProperty]
		public extern Uint8ClampedArray Data
		{
			get;
		}

		[FieldProperty]
		public extern int Height
		{
			get;
		}

		[FieldProperty]
		public extern int Width
		{
			get;
		}
	}
}
