using System;
using System.Collections.Generic;
using Generator.ExtensionMethods;

namespace Generator.AstNodes {
	public class ExtendedAttribute {
		public class NoArgsData {
			public string AttributeName { get; private set; }

			public NoArgsData(string attributeName) {
				AttributeName = attributeName;
			}
		}

		public class ArgListData {
			public string AttributeName { get; private set; }
			public IReadOnlyList<Argument> Arguments { get; private set; }

			public ArgListData(string attributeName, IReadOnlyList<Argument> arguments) {
				AttributeName = attributeName;
				Arguments = arguments;
			}
		}

		public class NamedArgListData {
			public string AttributeName { get; private set; }
			public string ArgListName { get; private set; }
			public IReadOnlyList<Argument> Arguments { get; private set; }

			public NamedArgListData(string attributeName, string argListName, IReadOnlyList<Argument> arguments) {
				AttributeName = attributeName;
				ArgListName = argListName;
				Arguments = arguments;
			}
		}

		public class IdentData {
			public string AttributeName { get; private set; }
			public string Ident { get; private set; }

			public IdentData(string attributeName, string ident) {
				AttributeName = attributeName;
				Ident = ident;
			}
		}

		public class ValueData {
			public string AttributeName { get; private set; }
			public Value Value { get; private set; }

			public ValueData(string attributeName, Value value) {
				AttributeName = attributeName;
				Value = value;
			}
		}

		private NoArgsData _noArgs;
		private ArgListData _argList;
		private NamedArgListData _namedArgList;
		private IdentData _ident;
		private ValueData _value;

		public void Decompose(Action<NoArgsData> noArgs, Action<ArgListData> argList, Action<NamedArgListData> namedArgList, Action<IdentData> ident, Action<ValueData> value) {
			if (_noArgs != null) {
				if (noArgs != null) noArgs(_noArgs);
			}
			else if (_argList != null) {
				if (argList != null) argList(_argList);
			}
			else if (_namedArgList != null) {
				if (namedArgList != null) namedArgList(_namedArgList);
			}
			else if (_ident != null) {
				if (ident != null) ident(_ident);
			}
			else if (_value != null) {
				if (value != null) value(_value);
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}

		public T DecomposeWithResult<T>(Func<NoArgsData, T> noArgs, Func<ArgListData, T> argList, Func<NamedArgListData, T> namedArgList, Func<IdentData, T> ident, Func<ValueData, T> value) {
			if (_noArgs != null) {
				if (noArgs != null)
					return noArgs(_noArgs);
				else
					throw new InvalidOperationException("Case 'NoArgs' not handled");
			}
			else if (_argList != null) {
				if (argList != null)
					return argList(_argList);
				else
					throw new InvalidOperationException("Case 'ArgList' not handled");
			}
			else if (_namedArgList != null) {
				if (namedArgList != null)
					return namedArgList(_namedArgList);
				else
					throw new InvalidOperationException("Case 'NamedArgList' not handled");
			}
			else if (_ident != null) {
				if (ident != null)
					return ident(_ident);
				else
					throw new InvalidOperationException("Case 'Ident' not handled");
			}
			else if (_value != null) {
				if (value != null)
					return value(_value);
				else
					throw new InvalidOperationException("Case 'Value' not handled");
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}

		public static ExtendedAttribute NoArgs(string attributeName) {
			return new ExtendedAttribute { _noArgs = new NoArgsData(attributeName) };
		}

		public static ExtendedAttribute ArgList(string attributeName, IEnumerable<Argument> arguments) {
			return new ExtendedAttribute { _argList = new ArgListData(attributeName, arguments.AsReadOnlySafe()) };
		}

		public static ExtendedAttribute NamedArgList(string attributeName, string argListName, IEnumerable<Argument> arguments) {
			return new ExtendedAttribute { _namedArgList = new NamedArgListData(attributeName, argListName, arguments.AsReadOnlySafe()) };
		}

		public static ExtendedAttribute Ident(string attributeName, string ident) {
			return new ExtendedAttribute { _ident = new IdentData(attributeName, ident) };
		}

		public static ExtendedAttribute Value(string attributeName, Value value) {
			return new ExtendedAttribute { _value = new ValueData(attributeName, value) };
		}
	}
}