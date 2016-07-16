namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Event
	{
		internal Event()
		{
		}

		public Event(string type)
		{
		}

		public Event(string type, EventInit eventInitDict)
		{
		}

		[Name("ALT_MASK")]
		public const int ALT_MASK = 1;

		[Name("AT_TARGET")]
		public const ushort AT_TARGET = 2;

		[FieldProperty]
		public bool Bubbles
		{
			get {
				return false;
			}
		}

		[Name("BUBBLING_PHASE")]
		public const ushort BUBBLING_PHASE = 3;

		[FieldProperty]
		public bool Cancelable
		{
			get {
				return false;
			}
		}

		[Name("CAPTURING_PHASE")]
		public const ushort CAPTURING_PHASE = 1;

		[Name("CONTROL_MASK")]
		public const int CONTROL_MASK = 2;

		[FieldProperty]
		public EventTarget CurrentTarget
		{
			get {
				return default(EventTarget);
			}
		}

		[FieldProperty]
		public bool DefaultPrevented
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public EventPhase EventPhase
		{
			get {
				return default(EventPhase);
			}
		}

		[FieldProperty]
		public EventTarget ExplicitOriginalTarget
		{
			get {
				return default(EventTarget);
			}
		}

		public bool GetPreventDefault()
		{
			return false;
		}

		public void InitEvent(string type, bool bubbles, bool cancelable)
		{
		}

		[FieldProperty]
		public bool IsTrusted
		{
			get {
				return false;
			}
		}

		[Name("META_MASK")]
		public const int META_MASK = 8;

		public const ushort NONE = 0;

		[FieldProperty]
		public EventTarget OriginalTarget
		{
			get {
				return default(EventTarget);
			}
		}

		public void PreventDefault()
		{
		}

		[Name("SHIFT_MASK")]
		public const int SHIFT_MASK = 4;

		public void StopImmediatePropagation()
		{
		}

		public void StopPropagation()
		{
		}

		[FieldProperty]
		public EventTarget Target
		{
			get {
				return default(EventTarget);
			}
		}

		[FieldProperty]
		public long TimeStamp
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public string Type
		{
			get {
				return null;
			}
		}
	}
}
