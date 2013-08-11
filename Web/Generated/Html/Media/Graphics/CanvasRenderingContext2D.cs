// CanvasRenderingContext2D.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CanvasRenderingContext2D {
		internal CanvasRenderingContext2D() {
		}

		public void Arc(double x, double y, double radius, double startAngle, double endAngle) {
		}

		public void Arc(double x, double y, double radius, double startAngle, double endAngle, bool anticlockwise) {
		}

		public void ArcTo(double x1, double y1, double x2, double y2, double radius) {
		}

		public void BeginPath() {
		}

		public void BezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y) {
		}

		[IntrinsicProperty]
		public CanvasElement Canvas {
			get { return default(CanvasElement); }
		}

		public void ClearRect(double x, double y, double w, double h) {
		}

		public void Clip() {
		}

		public void Clip(CanvasWindingRule winding) {
		}

		public void ClosePath() {
		}

		public ImageData CreateImageData(double sw, double sh) {
			return default(ImageData);
		}

		public ImageData CreateImageData(ImageData imagedata) {
			return default(ImageData);
		}

		public CanvasGradient CreateLinearGradient(double x0, double y0, double x1, double y1) {
			return default(CanvasGradient);
		}

		public CanvasPattern CreatePattern(TypeOption<ImageElement, CanvasElement, VideoElement> image, string repetition) {
			return default(CanvasPattern);
		}

		public CanvasGradient CreateRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1) {
			return default(CanvasGradient);
		}

		public void DrawImage(TypeOption<ImageElement, CanvasElement, VideoElement> image, double dx, double dy) {
		}

		public void DrawImage(TypeOption<ImageElement, CanvasElement, VideoElement> image, double dx, double dy, double dw, double dh) {
		}

		public void DrawImage(TypeOption<ImageElement, CanvasElement, VideoElement> image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) {
		}

		public void Fill() {
		}

		public void Fill(CanvasWindingRule winding) {
		}

		public void FillRect(double x, double y, double w, double h) {
		}

		[IntrinsicProperty]
		public TypeOption<string, CanvasGradient, CanvasPattern> FillStyle {
			get { return default(TypeOption<string, CanvasGradient, CanvasPattern>); }
			set { }
		}

		public void FillText(string text, double x, double y) {
		}

		public void FillText(string text, double x, double y, double maxWidth) {
		}

		[IntrinsicProperty]
		public string Font {
			get { return null; }
			set { }
		}

		public ImageData GetImageData(double sx, double sy, double sw, double sh) {
			return default(ImageData);
		}

		[IntrinsicProperty]
		public double GlobalAlpha {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public CompositeOperation GlobalCompositeOperation {
			get { return default(CompositeOperation); }
			set { }
		}

		public bool IsPointInPath(double x, double y) {
			return false;
		}

		public bool IsPointInPath(double x, double y, CanvasWindingRule winding) {
			return false;
		}

		public bool IsPointInStroke(double x, double y) {
			return false;
		}

		[IntrinsicProperty]
		public LineCap LineCap {
			get { return default(LineCap); }
			set { }
		}

		[IntrinsicProperty]
		public LineJoin LineJoin {
			get { return default(LineJoin); }
			set { }
		}

		public void LineTo(double x, double y) {
		}

		[IntrinsicProperty]
		public double LineWidth {
			get { return 0; }
			set { }
		}

		public TextMetrics MeasureText(string text) {
			return default(TextMetrics);
		}

		[IntrinsicProperty]
		public double MiterLimit {
			get { return 0; }
			set { }
		}

		public void MoveTo(double x, double y) {
		}

		public void PutImageData(ImageData imagedata, double dx, double dy) {
		}

		public void PutImageData(ImageData imagedata, double dx, double dy, double dirtyX, double dirtyY, double dirtyWidth, double dirtyHeight) {
		}

		public void QuadraticCurveTo(double cpx, double cpy, double x, double y) {
		}

		public void Rect(double x, double y, double w, double h) {
		}

		public void Restore() {
		}

		public void Rotate(double angle) {
		}

		public void Save() {
		}

		public void Scale(double x, double y) {
		}

		public void SetTransform(double a, double b, double c, double d, double e, double f) {
		}

		[IntrinsicProperty]
		public double ShadowBlur {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public string ShadowColor {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public double ShadowOffsetX {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double ShadowOffsetY {
			get { return 0; }
			set { }
		}

		public void Stroke() {
		}

		public void StrokeRect(double x, double y, double w, double h) {
		}

		[IntrinsicProperty]
		public TypeOption<string, CanvasGradient, CanvasPattern> StrokeStyle {
			get { return default(TypeOption<string, CanvasGradient, CanvasPattern>); }
			set { }
		}

		public void StrokeText(string text, double x, double y) {
		}

		public void StrokeText(string text, double x, double y, double maxWidth) {
		}

		[IntrinsicProperty]
		public TextAlign TextAlign {
			get { return default(TextAlign); }
			set { }
		}

		[IntrinsicProperty]
		public TextBaseline TextBaseline {
			get { return default(TextBaseline); }
			set { }
		}

		public void Transform(double a, double b, double c, double d, double e, double f) {
		}

		public void Translate(double x, double y) {
		}
	}
}
