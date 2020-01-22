using System.Collections.Generic;
using System.Linq;

using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.DAL.MemoryBased
{
	// Ilustracija implementacije In-Memory repozitorija korištenjem Singleton patterna
	public class AccountRepository : IAccountRepository
	{
		private static int _nextID = 1;
		private static AccountRepository _instance;

		private readonly List<Account>	_listAccounts = new List<Account>();

		private AccountRepository()
		{
			_listAccounts.Add(new ExpenditureSinkAccount(getNewID()));
		}

		public static AccountRepository getInstance()
		{
			return _instance ?? (_instance = new AccountRepository());
		}


		public int	getAccountNum()
		{
			return _listAccounts.Count;
		}
		public Account getAccountByName(string inAccName)
		{
			//foreach (var acc in _listAccounts)
			//	if (acc.Name == inAccName)
			//		return acc;

			var acc = (from l in _listAccounts where l.Name == inAccName select l).First();

			if( acc != null )
				return acc;

			throw new AccountDoesntExist();
		}
		public Account getAccountByID(int inAccID)
		{
			var acc = (from l in _listAccounts where l.Id == inAccID select l).First();
			return acc;
		}

		public List<AccountWithBalance> getAllAccountsWithBalance()
		{
			List<AccountWithBalance> listAccounts = _listAccounts.OfType<AccountWithBalance>().ToList();

			return listAccounts;
		}
		public List<int> getAllAccountsIDs()
		{
			return _listAccounts.Select(acc => acc.Id).ToList();
		}
		public List<int> getAllAccountsOfType(AccountTypesList.AccountTypesEnum inType)
		{
			return (from acc in _listAccounts where AccountTypesList.isAccountOfType(acc, inType) == true select acc.Id).ToList();
		}

		public int getNewID()
		{
			int nextID = _nextID;

			_nextID++;

			return nextID;
		}

		public bool doesAccountExists(string inAccName)
		{
			var acc = (from l in _listAccounts where l.Name == inAccName select l).First();

			return acc != null;
		}
		public ExpenditureSinkAccount getExpSinkAccount()
		{
			foreach (var acc in _listAccounts)
				if (acc is ExpenditureSinkAccount)
					return acc as ExpenditureSinkAccount;

			throw new NoExpSinkAccountException();
		}

		public void addAccount(Account inAcc)
		{
			// provjeriti da li već postoji account s tim imenom
			if (_listAccounts.Any(acc => acc.Name == inAcc.Name))
			{
				throw new AccountAlreadyExists();
			}

			// što ćemo s ID-jem?
			// provjeriti ćemo da li je neinicijaliziran ilii možda taj Id već postoji
			if ( inAcc.Id == Account.UndefinedAccountID || _listAccounts.Any(acc => acc.Id == inAcc.Id) )		
				inAcc.Id = getNewID();					// i redefinirati ga ako nije inicijaliziran

			_listAccounts.Add(inAcc);
		}

		public void deleteAccount(int inAccID)
		{
			
		}

	}
}
