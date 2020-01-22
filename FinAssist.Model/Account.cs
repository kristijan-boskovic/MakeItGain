namespace FinAssist.Model
{
	public class Account : EntityBase<int>
	{
		public static readonly int UndefinedAccountID = -1;

		// SVI defaultno konstruirani računi će nakon kreiranja imati ID -1
		// na taj način ćemo u repozitoriju prepoznati da nisu inicijalizirani, pa ćemo im definirati ID kod dodavanja
		public Account() : base(UndefinedAccountID)
		{
		}

		public Account(int inID, string inName) : base(inID)
		{
			Name = inName;
		}

		public string Name { get; set; }
	}
}