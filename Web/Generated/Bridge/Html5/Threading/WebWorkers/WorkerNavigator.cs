namespace Bridge.Html5.Threading.WebWorkers
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class WorkerNavigator
	{
		internal extern WorkerNavigator();

		[FieldProperty]
		public extern string AppCodeName
		{
			get;
		}

		[FieldProperty]
		public extern string AppName
		{
			get;
		}

		[FieldProperty]
		public extern string AppVersion
		{
			get;
		}

		[FieldProperty]
		public extern bool OnLine
		{
			get;
		}

		[FieldProperty]
		public extern string Platform
		{
			get;
		}

		[FieldProperty]
		public extern string Product
		{
			get;
		}

		public extern bool TaintEnabled();

		[FieldProperty]
		public extern string UserAgent
		{
			get;
		}
	}
}
