using System;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("HTMLOptionsCollection")]
	public partial class HtmlOptionsCollection : ElementCollection
	{
		internal extern HtmlOptionsCollection();

		[IndexerName("__Item"), FieldProperty]
		public OptionElement this[int index]
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
