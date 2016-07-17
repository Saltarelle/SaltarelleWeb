using Bridge.Html5.Xml;
using System;

namespace Bridge.Html5.Media
{
	[Namespace("false"), External]
	public partial class VTTCue : EventTarget
	{
		internal extern VTTCue();

		public extern VTTCue(double startTime, double endTime, string text);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<VTTCue> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<VTTCue> listener, bool capture);

		public extern void AddEventListener(VTTCueEvents type, Action listener);

		public extern void AddEventListener(VTTCueEvents type, Action listener, bool capture);

		public extern void AddEventListener(VTTCueEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(VTTCueEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(VTTCueEvents type, HtmlEventHandlerWithTarget<VTTCue> listener);

		public extern void AddEventListener(VTTCueEvents type, HtmlEventHandlerWithTarget<VTTCue> listener, bool capture);

		public extern void AddEventListener(VTTCueEvents type, IEventListener listener);

		public extern void AddEventListener(VTTCueEvents type, IEventListener listener, bool capture);

		public AlignSetting Align;

		public double EndTime;

		public extern XmlDocumentFragment GetCueAsHTML();

		public string Id;

		public TypeOption<int, AutoKeyword> Line;

		public AlignSetting LineAlign;

		[Name("onenter")]
		public HtmlEventHandler OnEnter;

		[Name("onexit")]
		public HtmlEventHandler OnExit;

		public bool PauseOnExit;

		public int Position;

		public AlignSetting PositionAlign;

		public VTTRegion Region;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<VTTCue> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<VTTCue> listener, bool capture);

		public extern void RemoveEventListener(VTTCueEvents type, Action listener);

		public extern void RemoveEventListener(VTTCueEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(VTTCueEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(VTTCueEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(VTTCueEvents type, HtmlEventHandlerWithTarget<VTTCue> listener);

		public extern void RemoveEventListener(VTTCueEvents type, HtmlEventHandlerWithTarget<VTTCue> listener, bool capture);

		public extern void RemoveEventListener(VTTCueEvents type, IEventListener listener);

		public extern void RemoveEventListener(VTTCueEvents type, IEventListener listener, bool capture);

		public int Size;

		public bool SnapToLines;

		public double StartTime;

		public string Text;

		public readonly TextTrack Track;

		public DirectionSetting Vertical;
	}
}
