﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class PluginArray {
		internal PluginArray() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public Plugin this[int index] {
			get {
				return default(Plugin);
			}
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public Plugin this[string name] {
			get {
				return default(Plugin);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<Plugin> GetEnumerator() {
			return null;
		}

		public Plugin Item(int index) {
			return default(Plugin);
		}

		[IntrinsicProperty]
		public int Length {
			get {
				return 0;
			}
		}

		public Plugin NamedItem(string name) {
			return default(Plugin);
		}

		public void Refresh() {
		}

		public void Refresh(bool reloadDocuments) {
		}
	}
}
