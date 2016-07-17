namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class ValidityState
	{
		internal extern ValidityState();

		public readonly bool BadInput;

		public readonly bool CustomError;

		public readonly bool PatternMismatch;

		public readonly bool RangeOverflow;

		public readonly bool RangeUnderflow;

		public readonly bool StepMismatch;

		public readonly bool TooLong;

		public readonly bool TypeMismatch;

		public readonly bool Valid;

		public readonly bool ValueMissing;
	}
}
