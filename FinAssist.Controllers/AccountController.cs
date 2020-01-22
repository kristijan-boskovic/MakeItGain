using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinAssist.Model;
using FinAssist.Model.Repositories;
using FinAssist.BaseLib;

namespace FinAssist.Controllers
{
	public class AccountController
	{
		public void AddNewAccount(IAddNewAccountView inForm, IAccountRepository accountRepository)
		{
			if (inForm.ShowViewModal() == true)
			{
				try
				{
					string Name = inForm.AccountName;
					string AccType = inForm.AccountType;
					float Balance = inForm.InitialBalance;

					int ID = accountRepository.getNewID();

					Account newAccount = AccountFactory.CreateAccount(ID, Name, AccType, Balance);

					accountRepository.addAccount(newAccount);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void EditAccount(IEditAccountView inForm, string accountName, IAccountRepository inRepo)
		{
			
		}

		public void ViewAccounts(IShowAccountsListView inForm, IAccountRepository accountRepository, IMainFormController mainController)
		{
			// dohvati sve accounte i proslijedi ih View-u
			List<AccountWithBalance> listAccounts = accountRepository.getAllAccountsWithBalance();

            // zašto proslijeđujemo i mainController?
            // zato što na ovom View-u imamo "Add new account" i "Edit new account" funkcionalnost!
			inForm.ShowModaless(mainController, listAccounts);
		}
	}
}
