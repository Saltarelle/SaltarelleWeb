using System;

namespace Bridge.Html5.Media.Graphics
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CanvasRenderingContext2D
	{
		internal extern CanvasRenderingContext2D();

		public extern void AddHitRegion();

		public extern void AddHitRegion(HitRegionOptions options);

		public extern void Arc(double x, double y, double radius, double startAngle, double endAngle);

		public extern void Arc(double x, double y, double radius, double startAngle, double endAngle, bool anticlockwise);

		public extern void ArcTo(double x1, double y1, double x2, double y2, double radius);

		public extern void BeginPath();

		public extern void BezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y);

		[FieldProperty]
		public extern CanvasElement Canvas
		{
			get;
		}

		public extern void ClearRect(double x, double y, double w, double h);

		public extern void Clip();

		public extern void Clip(CanvasWindingRule winding);

		public extern void Clip(Path2D path);

		public extern void Clip(Path2D path, CanvasWindingRule winding);

		public extern void ClosePath();

		public extern ImageData CreateImageData(double sw, double sh);

		public extern ImageData CreateImageData(ImageData imagedata);

		public extern CanvasGradient CreateLinearGradient(double x0, double y0, double x1, double y1);

		public extern CanvasPattern CreatePattern(TypeOption<ImageElement, CanvasElement, VideoElement> image, string repetition);

		public extern CanvasGradient CreateRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1);

		public extern bool DrawCustomFocusRing(Element element);

		public extern void DrawFocusIfNeeded(Element element);

		public extern void DrawImage(TypeOption<ImageElement, CanvasElement, VideoElement> image, double dx, double dy);

		public extern void DrawImage(TypeOption<ImageElement, CanvasElement, VideoElement> image, double dx, double dy, double dw, double dh);

		public extern void DrawImage(TypeOption<ImageElement, CanvasElement, VideoElement> image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh);

		public extern void Fill();

		public extern void Fill(CanvasWindingRule winding);

		public extern void Fill(Path2D path);

		public extern void Fill(Path2D path, CanvasWindingRule winding);

		public extern void FillRect(double x, double y, double w, double h);

		[FieldProperty]
		public extern TypeOption<string, CanvasGradient, CanvasPattern> FillStyle
		{
			get;
			set;
		}

		public extern void FillText(string text, double x, double y);

		public extern void FillText(string text, double x, double y, double maxWidth);

		[FieldProperty]
		public extern string Font
		{
			get;
			set;
		}

		public extern ImageData GetImageData(double sx, double sy, double sw, double sh);

		public extern double[] GetLineDash();

		[FieldProperty]
		public extern double GlobalAlpha
		{
			get;
			set;
		}

		[FieldProperty]
		public extern CompositeOperation GlobalCompositeOperation
		{
			get;
			set;
		}

		public extern bool IsPointInPath(double x, double y);

		public extern bool IsPointInPath(double x, double y, CanvasWindingRule winding);

		public extern bool IsPointInPath(Path2D path, double x, double y);

		public extern bool IsPointInPath(Path2D path, double x, double y, CanvasWindingRule winding);

		public extern bool IsPointInStroke(double x, double y);

		public extern bool IsPointInStroke(Path2D path, double x, double y);

		[FieldProperty]
		public extern LineCap LineCap
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double LineDashOffset
		{
			get;
			set;
		}

		[FieldProperty]
		public extern LineJoin LineJoin
		{
			get;
			set;
		}

		public extern void LineTo(double x, double y);

		[FieldProperty]
		public extern double LineWidth
		{
			get;
			set;
		}

		public extern TextMetrics MeasureText(string text);

		[FieldProperty]
		public extern double MiterLimit
		{
			get;
			set;
		}

		public extern void MoveTo(double x, double y);

		public extern void PutImageData(ImageData imagedata, double dx, double dy);

		public extern void PutImageData(ImageData imagedata, double dx, double dy, double dirtyX, double dirtyY, double dirtyWidth, double dirtyHeight);

		public extern void QuadraticCurveTo(double cpx, double cpy, double x, double y);

		public extern void Rect(double x, double y, double w, double h);

		public extern void RemoveHitRegion(string id);

		public extern void Restore();

		public extern void Rotate(double angle);

		public extern void Save();

		public extern void Scale(double x, double y);

		public extern void SetLineDash(double[] segments);

		public extern void SetTransform(double a, double b, double c, double d, double e, double f);

		[FieldProperty]
		public extern double ShadowBlur
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string ShadowColor
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double ShadowOffsetX
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double ShadowOffsetY
		{
			get;
			set;
		}

		public extern void Stroke();

		public extern void Stroke(Path2D path);

		public extern void StrokeRect(double x, double y, double w, double h);

		[FieldProperty]
		public extern TypeOption<string, CanvasGradient, CanvasPattern> StrokeStyle
		{
			get;
			set;
		}

		public extern void StrokeText(string text, double x, double y);

		public extern void StrokeText(string text, double x, double y, double maxWidth);

		[FieldProperty]
		public extern TextAlign TextAlign
		{
			get;
			set;
		}

		[FieldProperty]
		public extern TextBaseline TextBaseline
		{
			get;
			set;
		}

		public extern void Transform(double a, double b, double c, double d, double e, double f);

		public extern void Translate(double x, double y);
	}
}
