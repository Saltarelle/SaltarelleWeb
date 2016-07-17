namespace Bridge.Html5.Data.WebStorage
{
	[Namespace("false"), External]
	public partial class StorageEvent : Event
	{
		internal extern StorageEvent();

		public extern StorageEvent(string type);

		public extern StorageEvent(string type, StorageEventInit eventInitDict);

		public extern void InitStorageEvent(string type, bool canBubble, bool cancelable, string key, string oldValue, string newValue, string url, Storage storageArea);

		public readonly string Key;

		public readonly string NewValue;

		public readonly string OldValue;

		public readonly Storage StorageArea;

		public readonly string Url;
	}
}
