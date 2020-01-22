namespace FinAssist.Model
{
	public class CurrentAccount : AccountWithBalance
	{
		public CurrentAccount(int inID, string inName)
			: base(inID, inName)
		{
		}

		public CurrentAccount(int inID, string inName, float inBalance)
			: base(inID, inName, inBalance)
		{
		}
	}
}