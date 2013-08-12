using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Generator.ExtensionMethods;
using System.Linq;
using ICSharpCode.NRefactory.CSharp;

namespace Generator.Meta {
	public enum TypeKind {
		Default,
		Interface,
		Mixin,
	}

	public class TypeMetadata {
		public string TypeName { get; private set; }
		public string Namespace { get; private set; }
		public string CSharpName { get; private set; }
		public string ScriptName { get; private set; }
		public IReadOnlyList<string> TagNames { get; private set; }
		public bool Generate { get; private set; }
		public bool Inherit { get; private set; }
		public TypeKind TypeKind { get; private set; }
		public bool IncludeConstructors { get; private set; }
		public IReadOnlyList<TypeOverride> TypeOverrides { get; private set; }
		public AstType AliasFor { get; private set; }
		public IReadOnlyDictionary<string, string> Renames { get; private set; }
		public IReadOnlyList<string> Removes { get; private set; }

		public TypeMetadata(string typeName, string @namespace, string csharpName, string scriptName, IReadOnlyList<string> tagNames, bool generate, bool inherit, TypeKind typeKind, bool includeConstructors, IReadOnlyList<TypeOverride> typeOverrides, AstType aliasFor, IEnumerable<Tuple<string, string>> renames, IEnumerable<string> removes) {
			TypeName = typeName;
			Namespace = @namespace;
			CSharpName = csharpName;
			ScriptName = scriptName;
			TagNames = tagNames.AsReadOnlySafe();
			Generate = generate && typeKind != TypeKind.Mixin;
			Inherit = inherit;
			TypeKind = typeKind;
			IncludeConstructors = includeConstructors;
			TypeOverrides = typeOverrides.AsReadOnlySafe();
			AliasFor = aliasFor;
			Renames = new ReadOnlyDictionary<string, string>((renames ?? new Tuple<string, string>[0]).ToDictionary(x => x.Item1, x => x.Item2));
			Removes = removes.AsReadOnlySafe();
		}
	}
}