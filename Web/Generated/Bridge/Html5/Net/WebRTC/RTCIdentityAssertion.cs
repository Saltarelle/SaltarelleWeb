namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class RTCIdentityAssertion
	{
		internal extern RTCIdentityAssertion();

		public extern RTCIdentityAssertion(string idp, string name);

		[FieldProperty]
		public extern string Idp
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
			set;
		}
	}
}
