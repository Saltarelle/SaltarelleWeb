// CSSRule.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CSSRule {
		internal CSSRule() {
		}

		[ScriptName("CHARSET_RULE")]
		public const ushort CHARSET_RULE = 2;

		[IntrinsicProperty]
		public string CssText {
			get { return null; }
			set { }
		}

		[ScriptName("FONT_FACE_RULE")]
		public const ushort FONT_FACE_RULE = 5;

		[ScriptName("IMPORT_RULE")]
		public const ushort IMPORT_RULE = 3;

		[ScriptName("MEDIA_RULE")]
		public const ushort MEDIA_RULE = 4;

		[ScriptName("NAMESPACE_RULE")]
		public const ushort NAMESPACE_RULE = 10;

		[ScriptName("PAGE_RULE")]
		public const ushort PAGE_RULE = 6;

		[IntrinsicProperty]
		public CSSRule ParentRule {
			get { return default(CSSRule); }
		}

		[IntrinsicProperty]
		public CSSStyleSheet ParentStyleSheet {
			get { return default(CSSStyleSheet); }
		}

		[ScriptName("STYLE_RULE")]
		public const ushort STYLE_RULE = 1;

		[IntrinsicProperty]
		public CSSRuleType Type {
			get { return default(CSSRuleType); }
		}
	}
}
