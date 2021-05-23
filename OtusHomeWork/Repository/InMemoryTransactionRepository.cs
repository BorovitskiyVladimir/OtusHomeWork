using OtusHomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace OtusHomeWork.Repository
{
    public class InMemoryTransactionRepository : ITransactionRepository
    {
        private readonly List<ITransaction> _transactions = new List<ITransaction>();
        public void AddTransaction(ITransaction transaction)
        {
            _transactions.Add(transaction);
        }
        public ITransaction[] GetTransactions()
        {
            return _transactions.ToArray();
        }
    }
}
