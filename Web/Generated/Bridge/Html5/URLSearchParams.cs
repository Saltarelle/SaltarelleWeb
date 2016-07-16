namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class URLSearchParams
	{
		public extern URLSearchParams();

		public extern URLSearchParams(string init);

		public extern URLSearchParams(URLSearchParams init);

		public extern void Append(string name, string value);

		public extern void Delete(string name);

		public extern string Get(string name);

		public extern string[] GetAll(string name);

		public extern bool Has(string name);

		public extern void Set(string name, string value);
	}
}
