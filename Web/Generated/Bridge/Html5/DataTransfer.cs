using Bridge.Html5.IO;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DataTransfer
	{
		internal DataTransfer()
		{
		}

		public void AddElement(Element element)
		{
		}

		public void ClearData()
		{
		}

		public void ClearData(string format)
		{
		}

		[FieldProperty]
		public DropEffect DropEffect
		{
			get {
				return default(DropEffect);
			}
			set {
			}
		}

		[FieldProperty]
		public AllowedDropEffect EffectAllowed
		{
			get {
				return default(AllowedDropEffect);
			}
			set {
			}
		}

		[FieldProperty]
		public FileList Files
		{
			get {
				return default(FileList);
			}
		}

		public string GetData(string format)
		{
			return null;
		}

		public void SetData(string format, string data)
		{
		}

		public void SetDragImage(Element image, int x, int y)
		{
		}

		[FieldProperty]
		public DOMStringList Types
		{
			get {
				return default(DOMStringList);
			}
		}
	}
}
