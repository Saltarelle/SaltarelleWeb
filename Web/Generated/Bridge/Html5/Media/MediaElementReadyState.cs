namespace Bridge.Html5.Media
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum MediaElementReadyState
	{
		HaveNothing = 0,
		HaveMetadata = 1,
		HaveCurrentData = 2,
		HaveFutureData = 3,
		HaveEnoughData = 4
	}
}
