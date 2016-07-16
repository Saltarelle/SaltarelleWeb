using Bridge.Html5.Xml;
using System;

namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class VTTCue : EventTarget
	{
		internal VTTCue()
		{
		}

		public VTTCue(double startTime, double endTime, string text)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<VTTCue> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<VTTCue> listener, bool capture)
		{
		}

		public void AddEventListener(VTTCueEvents type, Action listener)
		{
		}

		public void AddEventListener(VTTCueEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(VTTCueEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(VTTCueEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(VTTCueEvents type, HtmlEventHandlerWithTarget<VTTCue> listener)
		{
		}

		public void AddEventListener(VTTCueEvents type, HtmlEventHandlerWithTarget<VTTCue> listener, bool capture)
		{
		}

		public void AddEventListener(VTTCueEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(VTTCueEvents type, IEventListener listener, bool capture)
		{
		}

		[FieldProperty]
		public AlignSetting Align
		{
			get {
				return default(AlignSetting);
			}
			set {
			}
		}

		[FieldProperty]
		public double EndTime
		{
			get {
				return 0;
			}
			set {
			}
		}

		public XmlDocumentFragment GetCueAsHTML()
		{
			return default(XmlDocumentFragment);
		}

		[FieldProperty]
		public string Id
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public TypeOption<int, AutoKeyword> Line
		{
			get {
				return default(TypeOption<int, AutoKeyword>);
			}
			set {
			}
		}

		[FieldProperty]
		public AlignSetting LineAlign
		{
			get {
				return default(AlignSetting);
			}
			set {
			}
		}

		[FieldProperty, Name("onenter")]
		public HtmlEventHandler OnEnter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onexit")]
		public HtmlEventHandler OnExit
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty]
		public bool PauseOnExit
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public int Position
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public AlignSetting PositionAlign
		{
			get {
				return default(AlignSetting);
			}
			set {
			}
		}

		[FieldProperty]
		public VTTRegion Region
		{
			get {
				return default(VTTRegion);
			}
			set {
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<VTTCue> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<VTTCue> listener, bool capture)
		{
		}

		public void RemoveEventListener(VTTCueEvents type, Action listener)
		{
		}

		public void RemoveEventListener(VTTCueEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(VTTCueEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(VTTCueEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(VTTCueEvents type, HtmlEventHandlerWithTarget<VTTCue> listener)
		{
		}

		public void RemoveEventListener(VTTCueEvents type, HtmlEventHandlerWithTarget<VTTCue> listener, bool capture)
		{
		}

		public void RemoveEventListener(VTTCueEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(VTTCueEvents type, IEventListener listener, bool capture)
		{
		}

		[FieldProperty]
		public int Size
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public bool SnapToLines
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public double StartTime
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public string Text
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public TextTrack Track
		{
			get {
				return default(TextTrack);
			}
		}

		[FieldProperty]
		public DirectionSetting Vertical
		{
			get {
				return default(DirectionSetting);
			}
			set {
			}
		}
	}
}
