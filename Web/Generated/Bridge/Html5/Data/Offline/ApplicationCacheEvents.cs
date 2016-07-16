namespace Bridge.Html5.Data.Offline
{
	[External, Enum(Emit.StringNamePreserveCase)]
	public enum ApplicationCacheEvents
	{
		Cached,
		Checking,
		Downloading,
		Error,
		Noupdate,
		Obsolete,
		Progress,
		Updateready
	}
}
