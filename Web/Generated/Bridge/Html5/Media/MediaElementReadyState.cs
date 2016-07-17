namespace Bridge.Html5.Media
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum MediaElementReadyState
	{
		HaveCurrentData = 2,
		HaveEnoughData = 4,
		HaveFutureData = 3,
		HaveMetadata = 1,
		HaveNothing = 0
	}
}
