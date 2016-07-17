namespace Bridge.Html5.Threading.WebWorkers
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class WorkerNavigator
	{
		internal extern WorkerNavigator();

		public readonly string AppCodeName;

		public readonly string AppName;

		public readonly string AppVersion;

		public readonly bool OnLine;

		public readonly string Platform;

		public readonly string Product;

		public extern bool TaintEnabled();

		public readonly string UserAgent;
	}
}
