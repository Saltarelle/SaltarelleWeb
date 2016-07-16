namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class PannerNode : AudioNode
	{
		internal PannerNode()
		{
		}

		public void AddEventListener(PannerNodeEvents type, Action listener)
		{
		}

		public void AddEventListener(PannerNodeEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(PannerNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(PannerNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(PannerNodeEvents type, HtmlEventHandlerWithTarget<PannerNode> listener)
		{
		}

		public void AddEventListener(PannerNodeEvents type, HtmlEventHandlerWithTarget<PannerNode> listener, bool capture)
		{
		}

		public void AddEventListener(PannerNodeEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(PannerNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<PannerNode> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<PannerNode> listener, bool capture)
		{
		}

		[FieldProperty]
		public double ConeInnerAngle
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public double ConeOuterAngle
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public double ConeOuterGain
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public DistanceModelType DistanceModel
		{
			get {
				return default(DistanceModelType);
			}
			set {
			}
		}

		public const ushort EQUALPOWER = 0;

		[Name("EXPONENTIAL_DISTANCE")]
		public const ushort EXPONENTIAL_DISTANCE = 2;

		public const ushort HRTF = 1;

		[Name("INVERSE_DISTANCE")]
		public const ushort INVERSE_DISTANCE = 1;

		[Name("LINEAR_DISTANCE")]
		public const ushort LINEAR_DISTANCE = 0;

		[FieldProperty]
		public double MaxDistance
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public PanningModelType PanningModel
		{
			get {
				return default(PanningModelType);
			}
			set {
			}
		}

		[FieldProperty]
		public double RefDistance
		{
			get {
				return 0;
			}
			set {
			}
		}

		public void RemoveEventListener(PannerNodeEvents type, Action listener)
		{
		}

		public void RemoveEventListener(PannerNodeEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(PannerNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(PannerNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(PannerNodeEvents type, HtmlEventHandlerWithTarget<PannerNode> listener)
		{
		}

		public void RemoveEventListener(PannerNodeEvents type, HtmlEventHandlerWithTarget<PannerNode> listener, bool capture)
		{
		}

		public void RemoveEventListener(PannerNodeEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(PannerNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<PannerNode> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<PannerNode> listener, bool capture)
		{
		}

		[FieldProperty]
		public double RolloffFactor
		{
			get {
				return 0;
			}
			set {
			}
		}

		public void SetOrientation(double x, double y, double z)
		{
		}

		public void SetPosition(double x, double y, double z)
		{
		}

		public void SetVelocity(double x, double y, double z)
		{
		}
	}
}
