using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.AstNodes {
	public class Value {
		public class SpecialData {
			public SpecialValue Value { get; private set; }

			public SpecialData(SpecialValue value) {
				Value = value;
			}
		}

		private int? _intValue;
		private double? _floatValue;
		private string _stringValue;
		private SpecialData _special;

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
			return new Value { _special = new SpecialData(SpecialValue.True) };
		}

		public static Value False() {
			return new Value { _special = new SpecialData(SpecialValue.False) };
		}

		public static Value Null() {
			return new Value { _special = new SpecialData(SpecialValue.Null) };
		}

		public static Value PositiveInfinity() {
			return new Value { _special = new SpecialData(SpecialValue.PositiveInfinity) };
		}

		public static Value NegativeInfinity() {
			return new Value { _special = new SpecialData(SpecialValue.NegativeInfinity) };
		}

		public static Value NaN() {
			return new Value { _special = new SpecialData(SpecialValue.NaN) };
		}

		public static Value Special(SpecialValue value) {
			return new Value { _special = new SpecialData(value) };
		}

		public void Decompose(Action<int> integer, Action<double> @float, Action<string> @string, Action<SpecialData> special) {
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
				if (special != null) special(_special);
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}

		public T Decompose<T>(Func<int, T> integer, Func<double, T> @float, Func<string, T> @string, Func<SpecialData, T> special) {
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
					return special(_special);
				else
					throw new InvalidOperationException("Case 'Special' not handled");
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}
	}
}
