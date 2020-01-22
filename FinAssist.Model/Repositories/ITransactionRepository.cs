using System.Collections.Generic;

namespace FinAssist.Model.Repositories
{
	public interface ITransactionRepository
	{
        int     getNewID();
        int     getTransactionNum();

        void    addTransaction(Transaction inTrans);
		Transaction getTransaction(int inTransID);
	}
}