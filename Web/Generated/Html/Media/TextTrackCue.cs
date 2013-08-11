// TextTrackCue.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html.Media {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class TextTrackCue : EventTarget {
		internal TextTrackCue() {
		}

		public TextTrackCue(double startTime, double endTime, string text) {
		}

		[IntrinsicProperty]
		public TextTrackCueAlign Align {
			get { return default(TextTrackCueAlign); }
			set { }
		}

		[IntrinsicProperty]
		public double EndTime {
			get { return 0; }
			set { }
		}

		public XmlDocumentFragment GetCueAsHTML() {
			return default(XmlDocumentFragment);
		}

		[IntrinsicProperty]
		public string Id {
			get { return null; }
			set { }
		}

		[IntrinsicProperty, ScriptName("onenter")]
		public HtmlEventHandler OnEnter {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onexit")]
		public HtmlEventHandler OnExit {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty]
		public bool PauseOnExit {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public int Position {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public int Size {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public bool SnapToLines {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public double StartTime {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public string Text {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public TextTrack Track {
			get { return default(TextTrack); }
		}

		[IntrinsicProperty]
		public string Vertical {
			get { return null; }
			set { }
		}
	}
}
