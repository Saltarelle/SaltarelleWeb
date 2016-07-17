namespace Bridge.Html5.Data.Offline
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum ApplicationCacheStatus
	{
		Checking = 2,
		Downloading = 3,
		Idle = 1,
		Obsolete = 5,
		Uncached = 0,
		Updateready = 4
	}
}
