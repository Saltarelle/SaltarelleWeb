namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External]
	public partial class RTCStatsReport
	{
		internal extern RTCStatsReport();

		public extern void ForEach(RTCStatsReportCallback callbackFn, object thisArg);

		public extern object Get(string key);

		public extern bool Has(string key);
	}
}
