using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.ExtensionMethods {
	static class EnumerableExtensions {
		public static IReadOnlyList<T> AsReadOnlySafe<T>(this IEnumerable<T> source) {
			if (source == null)
				return new T[0];
			else if (source is ReadOnlyCollection<T>)
				return (ReadOnlyCollection<T>)source;
			else
				return source.ToList().AsReadOnly();
		}
	}
}
