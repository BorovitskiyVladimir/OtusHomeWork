using System;
using System.Collections.Generic;
using System.Text;

namespace OtusHomeWork.Interfaces
{
    public interface ICurrencyAmount
    {
        string CurrencyCode { get; }
        decimal Amount { get; }
    }
}
