using System.Runtime.CompilerServices;

namespace System.Html {
	[BindThisToFirstParameter]
	public delegate void HtmlEventHandlerWithTarget<T>(T target, Event @event);
}