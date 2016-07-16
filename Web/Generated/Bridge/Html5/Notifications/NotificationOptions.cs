namespace Bridge.Html5.Notifications
{
	[External, Serializable]
	public partial class NotificationOptions
	{
		public string Body
		{
			get;
			set;
		}

		public NotificationDirection Dir
		{
			get;
			set;
		}

		public string Icon
		{
			get;
			set;
		}

		public string Lang
		{
			get;
			set;
		}

		public string Tag
		{
			get;
			set;
		}
	}
}
