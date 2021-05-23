using System;
using System.Collections.Generic;
using System.Text;

namespace OtusHomeWork.Interfaces
{
    public interface ITransactionRepository
    {
        void AddTransaction(ITransaction transaction);
        ITransaction[] GetTransactions();
    }
}
