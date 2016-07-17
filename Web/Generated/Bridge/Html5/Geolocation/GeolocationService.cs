namespace Bridge.Html5.Geolocation
{
	[Namespace("false"), External, Name("Object")]
	public partial class GeolocationService
	{
		internal extern GeolocationService();

		public extern void ClearWatch(int watchId);

		public extern void GetCurrentPosition(PositionCallback successCallback);

		public extern void GetCurrentPosition(PositionCallback successCallback, PositionErrorCallback errorCallback);

		public extern void GetCurrentPosition(PositionCallback successCallback, PositionErrorCallback errorCallback, PositionOptions options);

		public extern int WatchPosition(PositionCallback successCallback);

		public extern int WatchPosition(PositionCallback successCallback, PositionErrorCallback errorCallback);

		public extern int WatchPosition(PositionCallback successCallback, PositionErrorCallback errorCallback, PositionOptions options);
	}
}
