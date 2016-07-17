using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External, Name("CSSStyleDeclaration")]
	public partial class Style : IEnumerable<string>
	{
		internal extern Style();

		public extern string this[int index]
		{
			get;
		}

		public string AlignContent;

		public string AlignItems;

		public string AlignSelf;

		public string All;

		public string Animation;

		public string AnimationDelay;

		public string AnimationDirection;

		public string AnimationDuration;

		public string AnimationFillMode;

		public string AnimationIterationCount;

		public string AnimationName;

		public string AnimationPlayState;

		public string AnimationTimingFunction;

		public string BackfaceVisibility;

		public string Background;

		public string BackgroundAttachment;

		public string BackgroundBlendMode;

		public string BackgroundClip;

		public string BackgroundColor;

		public string BackgroundImage;

		public string BackgroundOrigin;

		public string BackgroundPosition;

		public string BackgroundRepeat;

		public string BackgroundSize;

		public string Border;

		public string BorderBottom;

		public string BorderBottomColor;

		public string BorderBottomLeftRadius;

		public string BorderBottomRightRadius;

		public string BorderBottomStyle;

		public string BorderBottomWidth;

		public string BorderCollapse;

		public string BorderColor;

		public string BorderImage;

		public string BorderImageOutset;

		public string BorderImageRepeat;

		public string BorderImageSlice;

		public string BorderImageSource;

		public string BorderImageWidth;

		public string BorderLeft;

		public string BorderLeftColor;

		public string BorderLeftStyle;

		public string BorderLeftWidth;

		public string BorderRadius;

		public string BorderRight;

		public string BorderRightColor;

		public string BorderRightStyle;

		public string BorderRightWidth;

		public string BorderSpacing;

		public string BorderStyle;

		public string BorderTop;

		public string BorderTopColor;

		public string BorderTopLeftRadius;

		public string BorderTopRightRadius;

		public string BorderTopStyle;

		public string BorderTopWidth;

		public string BorderWidth;

		public string Bottom;

		public string BoxShadow;

		public string BoxSizing;

		public string CaptionSide;

		public string Clear;

		public string Clip;

		public string ClipPath;

		public string ClipRule;

		public string Color;

		public string ColorInterpolation;

		public string ColorInterpolationFilters;

		public string Content;

		public string CounterIncrement;

		public string CounterReset;

		public string CssFloat;

		public string CssText;

		public string Cursor;

		public string Direction;

		public string Display;

		public string DominantBaseline;

		public string EmptyCells;

		public string Fill;

		public string FillOpacity;

		public string FillRule;

		public string Filter;

		public string Flex;

		public string FlexBasis;

		public string FlexDirection;

		public string FlexFlow;

		public string FlexGrow;

		public string FlexShrink;

		public string FlexWrap;

		public string FloodColor;

		public string FloodOpacity;

		public string Font;

		public string FontFamily;

		public string FontFeatureSettings;

		public string FontKerning;

		public string FontLanguageOverride;

		public string FontSize;

		public string FontSizeAdjust;

		public string FontStretch;

		public string FontStyle;

		public string FontSynthesis;

		public string FontVariant;

		public string FontVariantAlternates;

		public string FontVariantCaps;

		public string FontVariantEastAsian;

		public string FontVariantLigatures;

		public string FontVariantNumeric;

		public string FontVariantPosition;

		public string FontWeight;

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<string> GetEnumerator();

		public extern CSSValue GetPropertyCSSValue(string property);

		public extern string GetPropertyPriority(string property);

		public extern string GetPropertyValue(string property);

		public string Grid;

		public string GridArea;

		public string GridAutoColumns;

		public string GridAutoFlow;

		public string GridAutoPosition;

		public string GridAutoRows;

		public string GridColumn;

		public string GridColumnEnd;

		public string GridColumnStart;

		public string GridRow;

		public string GridRowEnd;

		public string GridRowStart;

		public string GridTemplate;

		public string GridTemplateAreas;

		public string GridTemplateColumns;

		public string GridTemplateRows;

		public string Height;

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public string ImageOrientation;

		public string ImageRendering;

		public string ImeMode;

		public extern string Item(int index);

		public string JustifyContent;

		public string Left;

		public readonly int Length;

		public string LetterSpacing;

		public string LightingColor;

		public string LineHeight;

		public string ListStyle;

		public string ListStyleImage;

		public string ListStylePosition;

		public string ListStyleType;

		public string Margin;

		public string MarginBottom;

		public string MarginLeft;

		public string MarginRight;

		public string MarginTop;

		public string Marker;

		public string MarkerEnd;

		public string MarkerMid;

		public string MarkerOffset;

		public string MarkerStart;

		public string Marks;

		public string Mask;

		public string MaskType;

		public string MaxHeight;

		public string MaxWidth;

		public string MinHeight;

		public string MinWidth;

		public string MixBlendMode;

		public string Opacity;

		public string Order;

		public string Orphans;

		public string Outline;

		public string OutlineColor;

		public string OutlineOffset;

		public string OutlineStyle;

		public string OutlineWidth;

		public string Overflow;

		public string OverflowClipBox;

		public string OverflowX;

		public string OverflowY;

		public string Padding;

		public string PaddingBottom;

		public string PaddingLeft;

		public string PaddingRight;

		public string PaddingTop;

		public string Page;

		public string PageBreakAfter;

		public string PageBreakBefore;

		public string PageBreakInside;

		public string PaintOrder;

		public readonly CSSRule ParentRule;

		public string Perspective;

		public string PerspectiveOrigin;

		public string PointerEvents;

		public string Position;

		public string Quotes;

		public extern string RemoveProperty(string property);

		public string Resize;

		public string Right;

		public extern void SetProperty(string property, string value);

		public extern void SetProperty(string property, string value, string priority);

		public string ShapeRendering;

		public string Size;

		public string StopColor;

		public string StopOpacity;

		public string Stroke;

		public string StrokeDasharray;

		public string StrokeDashoffset;

		public string StrokeLinecap;

		public string StrokeLinejoin;

		public string StrokeMiterlimit;

		public string StrokeOpacity;

		public string StrokeWidth;

		public string TableLayout;

		public string TextAlign;

		public string TextAnchor;

		public string TextCombineHorizontal;

		public string TextDecoration;

		public string TextIndent;

		public string TextOrientation;

		public string TextOverflow;

		public string TextRendering;

		public string TextShadow;

		public string TextTransform;

		public string Top;

		public string TouchAction;

		public string Transform;

		public string TransformOrigin;

		public string TransformStyle;

		public string Transition;

		public string TransitionDelay;

		public string TransitionDuration;

		public string TransitionProperty;

		public string TransitionTimingFunction;

		public string UnicodeBidi;

		public string VectorEffect;

		public string VerticalAlign;

		public string Visibility;

		public string WhiteSpace;

		public string Widows;

		public string Width;

		public string WillChange;

		public string WordBreak;

		public string WordSpacing;

		public string WordWrap;

		public string WritingMode;

		public string ZIndex;
	}
}
