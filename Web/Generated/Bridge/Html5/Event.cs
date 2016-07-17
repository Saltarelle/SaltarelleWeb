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

		public readonly bool Bubbles;

		[Name("BUBBLING_PHASE")]
		public const ushort BUBBLING_PHASE = 3;

		public readonly bool Cancelable;

		[Name("CAPTURING_PHASE")]
		public const ushort CAPTURING_PHASE = 1;

		[Name("CONTROL_MASK")]
		public const int CONTROL_MASK = 2;

		public readonly EventTarget CurrentTarget;

		public readonly bool DefaultPrevented;

		public readonly EventPhase EventPhase;

		public readonly EventTarget ExplicitOriginalTarget;

		public extern bool GetPreventDefault();

		public extern void InitEvent(string type, bool bubbles, bool cancelable);

		public readonly bool IsTrusted;

		[Name("META_MASK")]
		public const int META_MASK = 8;

		public const ushort NONE = 0;

		public readonly EventTarget OriginalTarget;

		public extern void PreventDefault();

		[Name("SHIFT_MASK")]
		public const int SHIFT_MASK = 4;

		public extern void StopImmediatePropagation();

		public extern void StopPropagation();

		public readonly EventTarget Target;

		public readonly long TimeStamp;

		public readonly string Type;
	}
}
