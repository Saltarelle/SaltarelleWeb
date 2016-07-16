﻿using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html.Media {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class VTTCue : EventTarget {
		internal VTTCue() {
		}

		public VTTCue(double startTime, double endTime, string text) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<VTTCue> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<VTTCue> listener, bool capture) {
		}

		public void AddEventListener(VTTCueEvents type, Action listener) {
		}

		public void AddEventListener(VTTCueEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(VTTCueEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(VTTCueEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(VTTCueEvents type, HtmlEventHandlerWithTarget<VTTCue> listener) {
		}

		public void AddEventListener(VTTCueEvents type, HtmlEventHandlerWithTarget<VTTCue> listener, bool capture) {
		}

		public void AddEventListener(VTTCueEvents type, IEventListener listener) {
		}

		public void AddEventListener(VTTCueEvents type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public AlignSetting Align {
			get {
				return default(AlignSetting);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double EndTime {
			get {
				return 0;
			}
			set {
			}
		}

		public XmlDocumentFragment GetCueAsHTML() {
			return default(XmlDocumentFragment);
		}

		[IntrinsicProperty]
		public string Id {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public TypeOption<int, AutoKeyword> Line {
			get {
				return default(TypeOption<int, AutoKeyword>);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public AlignSetting LineAlign {
			get {
				return default(AlignSetting);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onenter")]
		public HtmlEventHandler OnEnter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onexit")]
		public HtmlEventHandler OnExit {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool PauseOnExit {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int Position {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public AlignSetting PositionAlign {
			get {
				return default(AlignSetting);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public VTTRegion Region {
			get {
				return default(VTTRegion);
			}
			set {
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<VTTCue> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<VTTCue> listener, bool capture) {
		}

		public void RemoveEventListener(VTTCueEvents type, Action listener) {
		}

		public void RemoveEventListener(VTTCueEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(VTTCueEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(VTTCueEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(VTTCueEvents type, HtmlEventHandlerWithTarget<VTTCue> listener) {
		}

		public void RemoveEventListener(VTTCueEvents type, HtmlEventHandlerWithTarget<VTTCue> listener, bool capture) {
		}

		public void RemoveEventListener(VTTCueEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(VTTCueEvents type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public int Size {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool SnapToLines {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double StartTime {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Text {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public TextTrack Track {
			get {
				return default(TextTrack);
			}
		}

		[IntrinsicProperty]
		public DirectionSetting Vertical {
			get {
				return default(DirectionSetting);
			}
			set {
			}
		}
	}
}
