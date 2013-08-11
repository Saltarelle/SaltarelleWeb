// WindowInstance.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	/// <summary>
	/// The window object represents the current browser window, and is the top-level
	/// scripting object.
	/// </summary>
	[IgnoreNamespace]
	[Imported]
	public sealed class WindowInstance {
		private WindowInstance() {
		}

		/// <summary>
		/// Adds a listener for the specified event.
		/// </summary>
		/// <param name="eventName">The name of the event such as 'load'.</param>
		/// <param name="listener">The listener to be invoked in response to the event.</param>
		public void AddEventListener(string eventName, ElementEventListener listener) {
		}

		/// <summary>
		/// Adds a listener for the specified event.
		/// </summary>
		/// <param name="eventName">The name of the event such as 'load'.</param>
		/// <param name="listener">The listener to be invoked in response to the event.</param>
		/// <param name="useCapture">Whether the listener wants to initiate capturing the event.</param>
		public void AddEventListener(string eventName, ElementEventListener listener, bool useCapture) {
		}

		public void AttachEvent(string eventName, ElementEventHandler handler) {
		}

		public void Close() {
		}

		[IntrinsicProperty]
		public bool Closed {
			get { return false; }
		}

		[IntrinsicProperty]
		public string DefaultStatus {
			get { return null; }
			set { }
		}

		public void DetachEvent(string eventName, ElementEventHandler handler) {
		}

		public bool DispatchEvent(MutableEvent eventObject) {
			return false;
		}

		[IntrinsicProperty]
		public DocumentInstance Document {
			get { return null; }
		}

		[IntrinsicProperty]
		public IFrameElement FrameElement {
			get { return null; }
		}

		[IntrinsicProperty]
		public WindowInstance[] Frames {
			get { return null; }
		}

		[IntrinsicProperty]
		public int InnerHeight {
			get { return 0; }
		}

		[IntrinsicProperty]
		public int InnerWidth {
			get { return 0; }
		}

		[IntrinsicProperty]
		public Location Location {
			get { return null; }
		}

		public void Navigate(string url) {
		}

		[IntrinsicProperty]
		public WindowInstance Opener {
			get { return null; }
		}

		[IntrinsicProperty]
		public static int OuterHeight {
			get { return 0; }
		}

		[IntrinsicProperty]
		public static int OuterWidth {
			get { return 0; }
		}

		[IntrinsicProperty]
		public int PageXOffset {
			get { return 0; }
		}

		[IntrinsicProperty]
		public int PageYOffset {
			get { return 0; }
		}

		[IntrinsicProperty]
		public WindowInstance Parent {
			get { return null; }
		}

		public void PostMessage(string message, string targetOrigin) {
		}

		public void Print() {
		}

		/// <summary>
		/// Removes a listener for the specified event.
		/// </summary>
		/// <param name="eventName">The name of the event such as 'load'.</param>
		/// <param name="listener">The listener to be invoked in response to the event.</param>
		public void RemoveEventListener(string eventName, ElementEventListener listener) {
		}

		/// <summary>
		/// Removes a listener for the specified event.
		/// </summary>
		/// <param name="eventName">The name of the event such as 'load'.</param>
		/// <param name="listener">The listener to be invoked in response to the event.</param>
		/// <param name="useCapture">Whether the listener wants to initiate capturing the event.</param>
		public void RemoveEventListener(string eventName, ElementEventListener listener, bool useCapture) {
		}

		public void Scroll(int x, int y) {
		}

		public void ScrollBy(int x, int y) {
		}

		public void ScrollTo(int x, int y) {
		}

		[IntrinsicProperty]
		public WindowInstance Self {
			get { return null; }
		}

		[IntrinsicProperty]
		public string Status {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public WindowInstance Top {
			get { return null; }
		}
	}
}