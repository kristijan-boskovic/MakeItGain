namespace FinAssist.Model
{
	public class CashAccount : AccountWithBalance
	{
		public CashAccount()
		{
		}

		public CashAccount(int inID, string inName)
			: base(inID, inName)
		{
		}

		public CashAccount(int inID, string inName, float inBalance)
			: base(inID, inName, inBalance)
		{
		}
	}
}