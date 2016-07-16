namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Location
	{
		internal extern Location();

		public extern void Assign(string url);

		[FieldProperty]
		public extern string Hash
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Host
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Hostname
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Href
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Origin
		{
			get;
		}

		[FieldProperty]
		public extern string Password
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Pathname
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Port
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Protocol
		{
			get;
			set;
		}

		public extern void Reload();

		public extern void Replace(string url);

		[FieldProperty]
		public extern string Search
		{
			get;
			set;
		}

		[FieldProperty]
		public extern URLSearchParams SearchParams
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Username
		{
			get;
			set;
		}
	}
}
