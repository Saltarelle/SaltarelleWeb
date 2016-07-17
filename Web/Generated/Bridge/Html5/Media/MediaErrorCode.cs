namespace Bridge.Html5.Media
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum MediaErrorCode
	{
		Aborted = 1,
		Decode = 3,
		Network = 2,
		SrcNotSupported = 4
	}
}
