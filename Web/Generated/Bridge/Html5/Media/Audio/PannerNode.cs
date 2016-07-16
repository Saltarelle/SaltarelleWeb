namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class PannerNode : AudioNode
	{
		internal extern PannerNode();

		public extern void AddEventListener(PannerNodeEvents type, Action listener);

		public extern void AddEventListener(PannerNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(PannerNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(PannerNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(PannerNodeEvents type, HtmlEventHandlerWithTarget<PannerNode> listener);

		public extern void AddEventListener(PannerNodeEvents type, HtmlEventHandlerWithTarget<PannerNode> listener, bool capture);

		public extern void AddEventListener(PannerNodeEvents type, IEventListener listener);

		public extern void AddEventListener(PannerNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<PannerNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<PannerNode> listener, bool capture);

		[FieldProperty]
		public extern double ConeInnerAngle
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double ConeOuterAngle
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double ConeOuterGain
		{
			get;
			set;
		}

		[FieldProperty]
		public extern DistanceModelType DistanceModel
		{
			get;
			set;
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
		public extern double MaxDistance
		{
			get;
			set;
		}

		[FieldProperty]
		public extern PanningModelType PanningModel
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double RefDistance
		{
			get;
			set;
		}

		public extern void RemoveEventListener(PannerNodeEvents type, Action listener);

		public extern void RemoveEventListener(PannerNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(PannerNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(PannerNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(PannerNodeEvents type, HtmlEventHandlerWithTarget<PannerNode> listener);

		public extern void RemoveEventListener(PannerNodeEvents type, HtmlEventHandlerWithTarget<PannerNode> listener, bool capture);

		public extern void RemoveEventListener(PannerNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(PannerNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<PannerNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<PannerNode> listener, bool capture);

		[FieldProperty]
		public extern double RolloffFactor
		{
			get;
			set;
		}

		public extern void SetOrientation(double x, double y, double z);

		public extern void SetPosition(double x, double y, double z);

		public extern void SetVelocity(double x, double y, double z);
	}
}
