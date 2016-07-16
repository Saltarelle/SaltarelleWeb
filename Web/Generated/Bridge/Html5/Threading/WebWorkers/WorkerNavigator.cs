namespace Bridge.Html5.Threading.WebWorkers
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class WorkerNavigator
	{
		internal WorkerNavigator()
		{
		}

		[FieldProperty]
		public string AppCodeName
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string AppName
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string AppVersion
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public bool OnLine
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public string Platform
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string Product
		{
			get {
				return null;
			}
		}

		public bool TaintEnabled()
		{
			return false;
		}

		[FieldProperty]
		public string UserAgent
		{
			get {
				return null;
			}
		}
	}
}
