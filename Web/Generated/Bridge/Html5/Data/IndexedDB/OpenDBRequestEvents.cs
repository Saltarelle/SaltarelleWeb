namespace Bridge.Html5.Data.IndexedDB
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum OpenDBRequestEvents
	{
		Blocked,
		Error,
		Success,
		Upgradeneeded
	}
}
