using Bridge.Html5.IO;

namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class DataTransferItem
	{
		internal extern DataTransferItem();

		public extern File GetAsFile();

		public extern void GetAsString(Action<string> callback);

		public readonly DataTransferItemKind Kind;

		public readonly string Type;
	}
}
