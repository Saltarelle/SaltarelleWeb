namespace Bridge.Html5.Notifications
{
	[External, Serializable]
	public partial class NotificationOptions
	{
		public extern string Body
		{
			get;
			set;
		}

		public extern NotificationDirection Dir
		{
			get;
			set;
		}

		public extern string Icon
		{
			get;
			set;
		}

		public extern string Lang
		{
			get;
			set;
		}

		public extern string Tag
		{
			get;
			set;
		}
	}
}
