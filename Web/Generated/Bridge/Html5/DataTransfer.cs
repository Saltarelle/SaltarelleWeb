using Bridge.Html5.IO;

namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class DataTransfer
	{
		internal extern DataTransfer();

		public extern void AddElement(Element element);

		public extern void ClearData();

		public extern void ClearData(string format);

		public DropEffect DropEffect;

		public AllowedDropEffect EffectAllowed;

		public readonly FileList Files;

		public extern string GetData(string format);

		public extern void SetData(string format, string data);

		public extern void SetDragImage(Element image, int x, int y);

		public readonly DOMStringList Types;
	}
}
