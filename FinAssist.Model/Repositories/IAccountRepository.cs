using System.Collections.Generic;

namespace FinAssist.Model.Repositories
{
	public interface IAccountRepository
	{
		int		getAccountNum();
		Account getAccountByID(int inAccID);
		Account getAccountByName(string inAccName);
		List<AccountWithBalance> getAllAccountsWithBalance();
		List<int> getAllAccountsIDs();
		List<int> getAllAccountsOfType(AccountTypesList.AccountTypesEnum inType);

		int		getNewID();
		bool	doesAccountExists(string inAccName);
		ExpenditureSinkAccount getExpSinkAccount();

		void addAccount(Account inAcc);
		void deleteAccount(int inAccID);
	}
}