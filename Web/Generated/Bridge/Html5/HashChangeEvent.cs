namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class HashChangeEvent : Event
	{
		internal HashChangeEvent()
		{
		}

		public HashChangeEvent(string type)
		{
		}

		public HashChangeEvent(string type, HashChangeEventInit eventInitDict)
		{
		}

		public void InitHashChangeEvent(string type, bool canBubble, bool cancelable, string oldURL, string newURL)
		{
		}

		[FieldProperty]
		public string NewURL
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string OldURL
		{
			get {
				return null;
			}
		}
	}
}
