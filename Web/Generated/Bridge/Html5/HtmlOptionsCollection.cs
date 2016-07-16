using System;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("HTMLOptionsCollection")]
	public partial class HtmlOptionsCollection : ElementCollection
	{
		internal HtmlOptionsCollection()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public OptionElement this[int index]
		{
			set {
			}
		}

		public void Add(TypeOption<OptionElement, OptGroupElement> element)
		{
		}

		public void Add(TypeOption<OptionElement, OptGroupElement> element, TypeOption<Element, int> before)
		{
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
			set {
			}
		}

		public void Remove(int index)
		{
		}

		[FieldProperty]
		public int SelectedIndex
		{
			get {
				return 0;
			}
			set {
			}
		}
	}
}
