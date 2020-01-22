using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinAssist.Model
{
	public static class AccountTypesList
	{
		public enum AccountTypesEnum : int
		{
			CASH_ACCOUNT = 1,
			CURRENT_ACCOUNT = 2,
			CREDIT_CARD_ACCOUNT = 3,
			DEBIT_CARD_ACCOUNT = 4,
			INCOME_SOURCE_ACCOUNT = 5
		};

		public static Dictionary<AccountTypesEnum, string> AccTypeDict = new Dictionary<AccountTypesEnum, string>
		{
			{ AccountTypesEnum.CASH_ACCOUNT, "Cash account"},
			{ AccountTypesEnum.CURRENT_ACCOUNT, "Current account"},
			{ AccountTypesEnum.CREDIT_CARD_ACCOUNT, "Credit card account"},
			{ AccountTypesEnum.DEBIT_CARD_ACCOUNT, "Debit card account"},
			{ AccountTypesEnum.INCOME_SOURCE_ACCOUNT, "Income account"}
		};
		
		public static Dictionary<AccountTypesEnum, Type> AccMappingToTypesDict = new Dictionary<AccountTypesEnum, Type>
		{
			{ AccountTypesEnum.CASH_ACCOUNT, typeof(CashAccount)},
			{ AccountTypesEnum.CURRENT_ACCOUNT, typeof(CurrentAccount)},
			{ AccountTypesEnum.CREDIT_CARD_ACCOUNT, typeof(CreditCardAccount)},
			{ AccountTypesEnum.DEBIT_CARD_ACCOUNT, typeof(DebitCardAccount)},
			{ AccountTypesEnum.INCOME_SOURCE_ACCOUNT, typeof(IncomeSourceAccount)}
		};

		public static AccountTypesEnum getAccCode(string inAccTypeName)
		{
			foreach(var val in AccTypeDict)
				if (val.Value == inAccTypeName)
					return val.Key;

			throw new WrongAccountTypeNameInString();
		}

		public static string getAccountTypeName(Account inAcc)
		{
			foreach (var val in AccMappingToTypesDict)
				if (val.Value == inAcc.GetType())
					return AccTypeDict[val.Key];

			throw new AccountTypeNotInList();
		}

		public static List<string> getAccountTypesList()
		{
			return AccTypeDict.Select(a => a.Value).ToList();

			// LINQ izraz je ekvivalentan ovome:
			//List<string> accTypes = new List<string>();
			//foreach (var a in AccountTypesList.AccTypeDict)
			//	accTypes.Add(a.Value);

			//return accTypes;
		}

		public static bool isAccountOfType(Account inAcc, AccountTypesEnum inType)
		{
			if (inAcc.GetType() == AccMappingToTypesDict[inType])
				return true;

			return false;
		}
	}
}
