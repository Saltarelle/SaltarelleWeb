namespace Bridge.Html5.Data.WebStorage
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class StorageEvent : Event
	{
		internal extern StorageEvent();

		public extern StorageEvent(string type);

		public extern StorageEvent(string type, StorageEventInit eventInitDict);

		public extern void InitStorageEvent(string type, bool canBubble, bool cancelable, string key, string oldValue, string newValue, string url, Storage storageArea);

		[FieldProperty]
		public extern string Key
		{
			get;
		}

		[FieldProperty]
		public extern string NewValue
		{
			get;
		}

		[FieldProperty]
		public extern string OldValue
		{
			get;
		}

		[FieldProperty]
		public extern Storage StorageArea
		{
			get;
		}

		[FieldProperty]
		public extern string Url
		{
			get;
		}
	}
}
