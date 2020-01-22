namespace FinAssist.Model
{
	public class CreditCardAccount : AccountWithBalance
	{
		public CreditCardAccount(int inID, string inName)
			: base(inID, inName)
		{
		}

		public CreditCardAccount(int inID, string inName, float inBalance)
			: base(inID, inName, inBalance)
		{
		}
	}
}