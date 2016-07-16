namespace Bridge.Html5.Data.WebStorage
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class StorageEvent : Event
	{
		internal StorageEvent()
		{
		}

		public StorageEvent(string type)
		{
		}

		public StorageEvent(string type, StorageEventInit eventInitDict)
		{
		}

		public void InitStorageEvent(string type, bool canBubble, bool cancelable, string key, string oldValue, string newValue, string url, Storage storageArea)
		{
		}

		[FieldProperty]
		public string Key
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string NewValue
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string OldValue
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public Storage StorageArea
		{
			get {
				return default(Storage);
			}
		}

		[FieldProperty]
		public string Url
		{
			get {
				return null;
			}
		}
	}
}
