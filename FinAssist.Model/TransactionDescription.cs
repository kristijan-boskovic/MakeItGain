namespace FinAssist.Model
{
	public abstract class TransactionDescription
	{
		public TransactionDescription(string inDesc)
		{
			TransDesc = inDesc;
		}

		public string TransDesc { get; set; }
	}
}