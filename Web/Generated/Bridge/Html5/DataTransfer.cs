using Bridge.Html5.IO;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DataTransfer
	{
		internal extern DataTransfer();

		public extern void AddElement(Element element);

		public extern void ClearData();

		public extern void ClearData(string format);

		[FieldProperty]
		public extern DropEffect DropEffect
		{
			get;
			set;
		}

		[FieldProperty]
		public extern AllowedDropEffect EffectAllowed
		{
			get;
			set;
		}

		[FieldProperty]
		public extern FileList Files
		{
			get;
		}

		public extern string GetData(string format);

		public extern void SetData(string format, string data);

		public extern void SetDragImage(Element image, int x, int y);

		[FieldProperty]
		public extern DOMStringList Types
		{
			get;
		}
	}
}
