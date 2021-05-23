using OtusHomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtusHomeWork.Classes
{
    public class Comission : ITransaction
    {
        public ITransaction OriginalTransaction { get; }
        public ICurrencyAmount Amount { get; }
        public DateTimeOffset Date { get; }
        public override string ToString() => $"Комиссия в размере {Amount} за транзакцию: {OriginalTransaction}";
    }
}
