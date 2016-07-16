namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ValidityState
	{
		internal ValidityState()
		{
		}

		[FieldProperty]
		public bool BadInput
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public bool CustomError
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public bool PatternMismatch
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public bool RangeOverflow
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public bool RangeUnderflow
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public bool StepMismatch
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public bool TooLong
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public bool TypeMismatch
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public bool Valid
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public bool ValueMissing
		{
			get {
				return false;
			}
		}
	}
}
