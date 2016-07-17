namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMError
	{
		internal extern DOMError();

		public extern DOMError(string name);

		public extern DOMError(string name, string message);

		public readonly string Message;

		public readonly string Name;
	}
}
