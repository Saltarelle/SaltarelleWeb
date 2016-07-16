using Bridge.Html5.IO;

namespace Bridge.Html5.Net
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class FormData
	{
		public extern FormData();

		public extern FormData(FormElement form);

		public extern void Append(string name, Blob value);

		public extern void Append(string name, Blob value, string filename);

		public extern void Append(string name, string value);
	}
}
