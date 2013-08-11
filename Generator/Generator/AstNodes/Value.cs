using System;

namespace Generator.AstNodes {
	public class Value {
		private Value() {}

		private int? _intValue;
		private double? _floatValue;
		private string _stringValue;
		private SpecialValue? _special;

		public static Value Integer(int value) {
			return new Value { _intValue = value };
		}

		public static Value Float(double value) {
			return new Value { _floatValue = value };
		}

		public static Value String(string value) {
			return new Value { _stringValue = value };
		}

		public static Value True() {
			return new Value { _special = SpecialValue.True };
		}

		public static Value False() {
			return new Value { _special = SpecialValue.False };
		}

		public static Value Null() {
			return new Value { _special = SpecialValue.Null };
		}

		public static Value PositiveInfinity() {
			return new Value { _special = SpecialValue.PositiveInfinity };
		}

		public static Value NegativeInfinity() {
			return new Value { _special = SpecialValue.NegativeInfinity };
		}

		public static Value NaN() {
			return new Value { _special = SpecialValue.NaN };
		}

		public static Value Special(SpecialValue value) {
			return new Value { _special = value };
		}

		public void Decompose(Action<int> integer, Action<double> @float, Action<string> @string, Action<SpecialValue> special) {
			if (_intValue != null) {
				if (integer != null) integer(_intValue.Value);
			}
			else if (_floatValue != null) {
				if (@float != null) @float(_floatValue.Value);
			}
			else if (_stringValue != null) {
				if (@string != null) @string(_stringValue);
			}
			else if (_special != null) {
				if (special != null) special(_special.Value);
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}

		public T DecomposeWithResult<T>(Func<int, T> integer, Func<double, T> @float, Func<string, T> @string, Func<SpecialValue, T> special) {
			if (_intValue != null) {
				if (integer != null)
					return integer(_intValue.Value);
				else
					throw new InvalidOperationException("Case 'Int' not handled");
			}
			else if (_floatValue != null) {
				if (@float != null)
					return @float(_floatValue.Value);
				else
					throw new InvalidOperationException("Case 'Float' not handled");
			}
			else if (_stringValue != null) {
				if (@string != null)
					return @string(_stringValue);
				else
					throw new InvalidOperationException("Case 'String' not handled");
			}
			else if (_special != null) {
				if (special != null)
					return special(_special.Value);
				else
					throw new InvalidOperationException("Case 'Special' not handled");
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}
	}
}
