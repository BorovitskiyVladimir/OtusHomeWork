using System;
using System.Collections.Generic;
using System.Text;

namespace OtusHomeWork.Interfaces
{
    public interface ITransaction
    {
        DateTimeOffset Date { get; }
        ICurrencyAmount Amount { get; }
    }
}
