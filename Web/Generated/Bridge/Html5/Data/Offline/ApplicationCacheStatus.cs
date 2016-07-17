namespace Bridge.Html5.Data.Offline
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum ApplicationCacheStatus
	{
		Uncached = 0,
		Idle = 1,
		Checking = 2,
		Downloading = 3,
		Updateready = 4,
		Obsolete = 5
	}
}
