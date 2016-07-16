using Bridge.Html5.Xml;
using System;

namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
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

		[FieldProperty]
		public extern AlignSetting Align
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double EndTime
		{
			get;
			set;
		}

		public extern XmlDocumentFragment GetCueAsHTML();

		[FieldProperty]
		public extern string Id
		{
			get;
			set;
		}

		[FieldProperty]
		public extern TypeOption<int, AutoKeyword> Line
		{
			get;
			set;
		}

		[FieldProperty]
		public extern AlignSetting LineAlign
		{
			get;
			set;
		}

		[FieldProperty, Name("onenter")]
		public extern HtmlEventHandler OnEnter
		{
			get;
			set;
		}

		[FieldProperty, Name("onexit")]
		public extern HtmlEventHandler OnExit
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool PauseOnExit
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int Position
		{
			get;
			set;
		}

		[FieldProperty]
		public extern AlignSetting PositionAlign
		{
			get;
			set;
		}

		[FieldProperty]
		public extern VTTRegion Region
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern int Size
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool SnapToLines
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double StartTime
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Text
		{
			get;
			set;
		}

		[FieldProperty]
		public extern TextTrack Track
		{
			get;
		}

		[FieldProperty]
		public extern DirectionSetting Vertical
		{
			get;
			set;
		}
	}
}
