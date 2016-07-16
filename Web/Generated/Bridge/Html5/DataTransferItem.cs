using Bridge.Html5.IO;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DataTransferItem
	{
		internal extern DataTransferItem();

		public extern File GetAsFile();

		public extern void GetAsString(Action<string> callback);

		[FieldProperty]
		public extern DataTransferItemKind Kind
		{
			get;
		}

		[FieldProperty]
		public extern string Type
		{
			get;
		}
	}
}
