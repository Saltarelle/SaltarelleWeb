namespace Bridge.Html5.Media.Audio
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum ChannelCountMode
	{
		Max,
		[Name("clamped-max")]
		ClampedMax,
		Explicit
	}
}
