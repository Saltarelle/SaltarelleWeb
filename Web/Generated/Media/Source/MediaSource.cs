﻿using System.Html;
using System.Html.Media.Audio;
using System.Runtime.CompilerServices;

namespace System.Media.Source {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MediaSource : EventTarget {
		public MediaSource() {
		}

		[IntrinsicProperty]
		public SourceBufferList ActiveSourceBuffers {
			get {
				return default(SourceBufferList);
			}
		}

		public void AddEventListener(MediaSourceEvents type, Action listener) {
		}

		public void AddEventListener(MediaSourceEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(MediaSourceEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(MediaSourceEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(MediaSourceEvents type, HtmlEventHandlerWithTarget<MediaSource> listener) {
		}

		public void AddEventListener(MediaSourceEvents type, HtmlEventHandlerWithTarget<MediaSource> listener, bool capture) {
		}

		public void AddEventListener(MediaSourceEvents type, IEventListener listener) {
		}

		public void AddEventListener(MediaSourceEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaSource> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaSource> listener, bool capture) {
		}

		public SourceBuffer AddSourceBuffer(string type) {
			return default(SourceBuffer);
		}

		[IntrinsicProperty]
		public double Duration {
			get {
				return 0;
			}
			set {
			}
		}

		public void EndOfStream() {
		}

		public void EndOfStream(MediaSourceEndOfStreamError error) {
		}

		public static bool IsTypeSupported(string type) {
			return false;
		}

		[IntrinsicProperty]
		public MediaSourceReadyState ReadyState {
			get {
				return default(MediaSourceReadyState);
			}
		}

		public void RemoveEventListener(MediaSourceEvents type, Action listener) {
		}

		public void RemoveEventListener(MediaSourceEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(MediaSourceEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(MediaSourceEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(MediaSourceEvents type, HtmlEventHandlerWithTarget<MediaSource> listener) {
		}

		public void RemoveEventListener(MediaSourceEvents type, HtmlEventHandlerWithTarget<MediaSource> listener, bool capture) {
		}

		public void RemoveEventListener(MediaSourceEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(MediaSourceEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaSource> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaSource> listener, bool capture) {
		}

		public void RemoveSourceBuffer(SourceBuffer sourceBuffer) {
		}

		[IntrinsicProperty]
		public SourceBufferList SourceBuffers {
			get {
				return default(SourceBufferList);
			}
		}
	}
}
