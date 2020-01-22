using System.Collections.Generic;
using System.Linq;

using FinAssist.BaseLib;
using FinAssist.Model;
using FinAssist.Model.Repositories;

namespace FinAssist.DAL.MemoryBased
{
	// Ilustracija In-Memory repozitorija BEZ korištenja Singleton patterna
	public class TransactionRepository  : ITransactionRepository
	{
        private int _nextID = 1;

        private readonly List<Transaction> _listTrans = new List<Transaction>();

	    public int getNewID()
	    {
            int nextID = _nextID;

            _nextID++;

            return nextID;
        }

        public int getTransactionNum()
	    {
	        return _listTrans.Count;
	    }

	    public void addTransaction(Transaction inTrans)
		{
			if (_listTrans.Any(trans => trans.Id == inTrans.Id))
				throw new TransactionIDAlreadyExists();

			_listTrans.Add(inTrans);
		}

        public Transaction getTransaction(int inTransID)
		{
			var trans = (from tr in _listTrans where tr.Id == inTransID select tr).First();
			return trans;
		}
	}
}
