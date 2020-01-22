namespace FinAssist.Model
{
	public abstract class AccountWithBalance : Account
	{
		public AccountWithBalance()
		{
		}

		public AccountWithBalance(int inID, string inName)
			: base(inID, inName)
		{
			InitialBalance = 0.0F;
		}

		public AccountWithBalance(int inID, string inName, float inBalance)
			: base(inID, inName)
		{
			InitialBalance = inBalance;
		}

		public virtual float InitialBalance { get; }
	}
}