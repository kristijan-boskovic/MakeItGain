 namespace FinAssist.Model
{
	public class AccountFactory
	{
		// PITANJE ZA DISKUSIJU - koliki benefit nam nose ove Tvornice???
		public static CashAccount CreateCashAccount(int inID, string inCashAccountName, float inInitialBalance)
		{
			return new CashAccount(inID, inCashAccountName, inInitialBalance);
		}

		public static CurrentAccount CreateCurrentAccount(int inID, string inCurrentAccountName, float inInitialBalance)
		{
			return new CurrentAccount(inID, inCurrentAccountName, inInitialBalance);
		}

		public static CreditCardAccount CreateCreditCardAccount(int inID, string inCreditCardAccountName, float inInitialBalance)
		{
			return new CreditCardAccount(inID, inCreditCardAccountName, inInitialBalance);
		}

		public static IncomeSourceAccount CreateIncomeSourceAccount(int inID, string inIncomeAccountName)
		{
			return new IncomeSourceAccount(inID, inIncomeAccountName);
		}


		// A ova?
		public static Account CreateAccount(int inID, string inName, string inType, float inBalance)
		{
			Account retAcc = null;

			switch(AccountTypesList.getAccCode(inType))
			{
				case AccountTypesList.AccountTypesEnum.CASH_ACCOUNT:
					retAcc = new CashAccount(inID, inName, inBalance);
					break;
				case AccountTypesList.AccountTypesEnum.CURRENT_ACCOUNT:
					retAcc = new CurrentAccount(inID, inName, inBalance);
					break;
				case AccountTypesList.AccountTypesEnum.CREDIT_CARD_ACCOUNT:
					retAcc = new CreditCardAccount(inID, inName, inBalance);
					break;
				case AccountTypesList.AccountTypesEnum.DEBIT_CARD_ACCOUNT:
					retAcc = new DebitCardAccount(inID, inName, inBalance);
					break;
				case AccountTypesList.AccountTypesEnum.INCOME_SOURCE_ACCOUNT:
					retAcc = new IncomeSourceAccount(inID, inName);
					break;
				default:
					throw new WrongAccountTypeNameInString();
			}

			return retAcc;
		}
	}
}