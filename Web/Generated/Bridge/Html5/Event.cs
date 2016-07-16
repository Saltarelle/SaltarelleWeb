namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Event
	{
		internal extern Event();

		public extern Event(string type);

		public extern Event(string type, EventInit eventInitDict);

		[Name("ALT_MASK")]
		public const int ALT_MASK = 1;

		[Name("AT_TARGET")]
		public const ushort AT_TARGET = 2;

		[FieldProperty]
		public extern bool Bubbles
		{
			get;
		}

		[Name("BUBBLING_PHASE")]
		public const ushort BUBBLING_PHASE = 3;

		[FieldProperty]
		public extern bool Cancelable
		{
			get;
		}

		[Name("CAPTURING_PHASE")]
		public const ushort CAPTURING_PHASE = 1;

		[Name("CONTROL_MASK")]
		public const int CONTROL_MASK = 2;

		[FieldProperty]
		public extern EventTarget CurrentTarget
		{
			get;
		}

		[FieldProperty]
		public extern bool DefaultPrevented
		{
			get;
		}

		[FieldProperty]
		public extern EventPhase EventPhase
		{
			get;
		}

		[FieldProperty]
		public extern EventTarget ExplicitOriginalTarget
		{
			get;
		}

		public extern bool GetPreventDefault();

		public extern void InitEvent(string type, bool bubbles, bool cancelable);

		[FieldProperty]
		public extern bool IsTrusted
		{
			get;
		}

		[Name("META_MASK")]
		public const int META_MASK = 8;

		public const ushort NONE = 0;

		[FieldProperty]
		public extern EventTarget OriginalTarget
		{
			get;
		}

		public extern void PreventDefault();

		[Name("SHIFT_MASK")]
		public const int SHIFT_MASK = 4;

		public extern void StopImmediatePropagation();

		public extern void StopPropagation();

		[FieldProperty]
		public extern EventTarget Target
		{
			get;
		}

		[FieldProperty]
		public extern long TimeStamp
		{
			get;
		}

		[FieldProperty]
		public extern string Type
		{
			get;
		}
	}
}
