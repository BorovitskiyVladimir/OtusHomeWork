using OtusHomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OtusHomeWork.Repository
{
    public class LoggingTransactionRepository : ITransactionRepository // декоратор
    {
        private ITransactionRepository transactionRepository;
        public LoggingTransactionRepository(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }
        public void AddTransaction(ITransaction transaction)
        {
            Trace.WriteLine("AddTransaction");
            transactionRepository.AddTransaction(transaction);
        }
        public ITransaction[] GetTransactions()
        {
            Trace.WriteLine("GetTransactions");
            return transactionRepository.GetTransactions();
        }
    }
}

