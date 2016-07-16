namespace Bridge.Html5.Threading.WebWorkers
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class WorkerLocation
	{
		internal extern WorkerLocation();

		[FieldProperty]
		public extern string Hash
		{
			get;
		}

		[FieldProperty]
		public extern string Host
		{
			get;
		}

		[FieldProperty]
		public extern string Hostname
		{
			get;
		}

		[FieldProperty]
		public extern string Href
		{
			get;
		}

		[FieldProperty]
		public extern string Origin
		{
			get;
		}

		[FieldProperty]
		public extern string Pathname
		{
			get;
		}

		[FieldProperty]
		public extern string Port
		{
			get;
		}

		[FieldProperty]
		public extern string Protocol
		{
			get;
		}

		[FieldProperty]
		public extern string Search
		{
			get;
		}
	}
}
