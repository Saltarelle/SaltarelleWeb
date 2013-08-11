// SVGSVGElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGSVGElement : SVGGraphicsElement {
		internal SVGSVGElement() {
		}

		public bool AnimationsPaused() {
			return false;
		}

		public SVGAngle CreateSVGAngle() {
			return default(SVGAngle);
		}

		public SVGLength CreateSVGLength() {
			return default(SVGLength);
		}

		public SVGMatrix CreateSVGMatrix() {
			return default(SVGMatrix);
		}

		public SVGNumber CreateSVGNumber() {
			return default(SVGNumber);
		}

		public SVGPoint CreateSVGPoint() {
			return default(SVGPoint);
		}

		public SVGRect CreateSVGRect() {
			return default(SVGRect);
		}

		public SVGTransform CreateSVGTransform() {
			return default(SVGTransform);
		}

		public SVGTransform CreateSVGTransformFromMatrix(SVGMatrix matrix) {
			return default(SVGTransform);
		}

		[IntrinsicProperty]
		public float CurrentScale {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public SVGPoint CurrentTranslate {
			get { return default(SVGPoint); }
		}

		public void DeselectAll() {
		}

		public void ForceRedraw() {
		}

		public float GetCurrentTime() {
			return 0;
		}

		public XmlElement GetElementById(string elementId) {
			return default(XmlElement);
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Height {
			get { return default(SVGAnimatedLength); }
		}

		public void PauseAnimations() {
		}

		[IntrinsicProperty]
		public float PixelUnitToMillimeterX {
			get { return 0; }
		}

		[IntrinsicProperty]
		public float PixelUnitToMillimeterY {
			get { return 0; }
		}

		[IntrinsicProperty]
		public SVGAnimatedPreserveAspectRatio PreserveAspectRatio {
			get { return default(SVGAnimatedPreserveAspectRatio); }
		}

		[IntrinsicProperty]
		public float ScreenPixelToMillimeterX {
			get { return 0; }
		}

		[IntrinsicProperty]
		public float ScreenPixelToMillimeterY {
			get { return 0; }
		}

		public void SetCurrentTime(float seconds) {
		}

		public uint SuspendRedraw(uint maxWaitMilliseconds) {
			return 0;
		}

		[ScriptName("SVG_ZOOMANDPAN_DISABLE")]
		public const ushort SVG_ZOOMANDPAN_DISABLE = 1;

		[ScriptName("SVG_ZOOMANDPAN_MAGNIFY")]
		public const ushort SVG_ZOOMANDPAN_MAGNIFY = 2;

		[ScriptName("SVG_ZOOMANDPAN_UNKNOWN")]
		public const ushort SVG_ZOOMANDPAN_UNKNOWN = 0;

		public void UnpauseAnimations() {
		}

		public void UnsuspendRedraw(uint suspendHandleID) {
		}

		public void UnsuspendRedrawAll() {
		}

		[IntrinsicProperty]
		public bool UseCurrentView {
			get { return false; }
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Width {
			get { return default(SVGAnimatedLength); }
		}

		[IntrinsicProperty]
		public SVGAnimatedRect ViewBox {
			get { return default(SVGAnimatedRect); }
		}

		[IntrinsicProperty]
		public SVGAnimatedLength X {
			get { return default(SVGAnimatedLength); }
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Y {
			get { return default(SVGAnimatedLength); }
		}

		[IntrinsicProperty]
		public SVGZoomAndPanType ZoomAndPan {
			get { return default(SVGZoomAndPanType); }
			set { }
		}
	}
}
