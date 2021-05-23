using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomeWork.Interfaces
{
    public interface ICurrencyConverter
    {
        ICurrencyAmount ConvertCurrency(ICurrencyAmount amount, string currencyCode);
    }
}
