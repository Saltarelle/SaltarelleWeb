using System;

namespace Bridge.Html5
{
	[Namespace(false), External, Name("HTMLOptionsCollection")]
	public partial class HtmlOptionsCollection : ElementCollection
	{
		internal extern HtmlOptionsCollection();

		public extern OptionElement this[int index]
		{
			set;
		}

		public extern void Add(TypeOption<OptionElement, OptGroupElement> element);

		public extern void Add(TypeOption<OptionElement, OptGroupElement> element, TypeOption<Element, int> before);

		public int Length;

		public extern void Remove(int index);

		public int SelectedIndex;
	}
}
