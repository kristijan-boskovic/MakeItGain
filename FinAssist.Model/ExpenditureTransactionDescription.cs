namespace FinAssist.Model
{
	public class ExpenditureTransDescription : TransactionDescription
	{
		private ExpenditureCategory _expCategory;
		private ExpenditurePlace _expPlace;

		public ExpenditureTransDescription(string inDesc, ExpenditureCategory inCat, ExpenditurePlace inPlace)
			: base(inDesc)
		{
			_expCategory = inCat;
			_expPlace = inPlace;
		}
	}
}