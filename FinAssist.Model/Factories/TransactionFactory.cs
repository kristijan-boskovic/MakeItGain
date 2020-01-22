using System;
using FinAssist.Model.Repositories;

namespace FinAssist.Model
{
	public class TransactionFactory
	{
		// TODO - dodati kreiranje s imenom kategorije i nazivom mjesta
		public static Transaction CreateExpenditureTransaction(float inAmount, DateTime inDate, Account fromAccount,
																string inDesc, ExpenditureCategory inExpCat, ExpenditurePlace inExpPlace, 
																IAccountRepository inAccRepo)
		{
			var desc = new ExpenditureTransDescription(inDesc, inExpCat, inExpPlace);

			var newTrans = new Transaction(inAmount, inDate, fromAccount, inAccRepo.getExpSinkAccount(), desc);

			return newTrans;
		}

		public static Transaction CreateTransferTransaction(float inAmount, DateTime inDate, Account fromAccount,
															Account toAcount, string inDesc)
		{
			var desc = new TransferTransDescription(inDesc);

			var newTrans = new Transaction(inAmount, inDate, fromAccount, toAcount, desc);

			return newTrans;
		}
	}
}