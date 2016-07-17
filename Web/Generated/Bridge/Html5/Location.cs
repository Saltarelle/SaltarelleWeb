namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class Location
	{
		internal extern Location();

		public extern void Assign(string url);

		public string Hash;

		public string Host;

		public string Hostname;

		public string Href;

		public readonly string Origin;

		public string Password;

		public string Pathname;

		public string Port;

		public string Protocol;

		public extern void Reload();

		public extern void Replace(string url);

		public string Search;

		public URLSearchParams SearchParams;

		public string Username;
	}
}
