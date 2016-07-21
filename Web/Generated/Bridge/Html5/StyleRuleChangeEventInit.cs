﻿using Bridge.Html5.CSS;

namespace Bridge.Html5
{
	[External]
	public partial class StyleRuleChangeEventInit : EventInit
	{
		public CSSRule Rule;

		public CSSStyleSheet Stylesheet;
	}
}
