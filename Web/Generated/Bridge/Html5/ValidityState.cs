namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ValidityState
	{
		internal extern ValidityState();

		[FieldProperty]
		public extern bool BadInput
		{
			get;
		}

		[FieldProperty]
		public extern bool CustomError
		{
			get;
		}

		[FieldProperty]
		public extern bool PatternMismatch
		{
			get;
		}

		[FieldProperty]
		public extern bool RangeOverflow
		{
			get;
		}

		[FieldProperty]
		public extern bool RangeUnderflow
		{
			get;
		}

		[FieldProperty]
		public extern bool StepMismatch
		{
			get;
		}

		[FieldProperty]
		public extern bool TooLong
		{
			get;
		}

		[FieldProperty]
		public extern bool TypeMismatch
		{
			get;
		}

		[FieldProperty]
		public extern bool Valid
		{
			get;
		}

		[FieldProperty]
		public extern bool ValueMissing
		{
			get;
		}
	}
}
