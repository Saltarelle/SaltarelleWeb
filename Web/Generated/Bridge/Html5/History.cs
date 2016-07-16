namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class History
	{
		internal History()
		{
		}

		public void Back()
		{
		}

		public void Forward()
		{
		}

		public void Go()
		{
		}

		public void Go(int delta)
		{
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}

		public void PushState(object data, string title)
		{
		}

		public void PushState(object data, string title, string url)
		{
		}

		public void ReplaceState(object data, string title)
		{
		}

		public void ReplaceState(object data, string title, string url)
		{
		}

		[FieldProperty]
		public object State
		{
			get {
				return null;
			}
		}
	}
}
