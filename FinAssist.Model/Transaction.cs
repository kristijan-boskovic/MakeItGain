using System;

namespace FinAssist.Model
{
	public class Transaction : EntityBase<int>
	{
		private TransactionDescription _transDescr;

		public Transaction(float inAmount, DateTime inDate, Account fromAcc, Account toAcc, TransactionDescription inTransDesc)
			: base(0)
		{
			Amount = inAmount;
			TransDate = inDate;
			ToAcc = toAcc;
			FromAcc = fromAcc;

			_transDescr = inTransDesc;
		}

		public float Amount { get; set; }
		public DateTime TransDate { get; set; }
		public Account FromAcc { get; }
		public Account ToAcc { get; }
	}
}