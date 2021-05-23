using System;
using System.Collections.Generic;
using System.Text;

namespace OtusHomeWork.Interfaces
{
    public interface IBudgetApplication
    {
        void AddTransaction(string input);
        void OutputTransactions();
        void OutputBalanceInCurrency(string currencyCode);
    }
}
