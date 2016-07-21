using Bridge.Html5.Nodes;
using System;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External]
	public partial class HTMLOptionsCollection : HTMLCollection
	{
		internal extern HTMLOptionsCollection();

		public extern HTMLOptionElement this[int index]
		{
			set;
		}

		public extern void Add(TypeOption<HTMLOptionElement, HTMLOptGroupElement> element);

		public extern void Add(TypeOption<HTMLOptionElement, HTMLOptGroupElement> element, TypeOption<HTMLElement, int> before);

		public int Length;

		public extern void Remove(int index);

		public int SelectedIndex;
	}
}
