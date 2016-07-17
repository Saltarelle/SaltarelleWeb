namespace Bridge.Html5.Data.Offline
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
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
