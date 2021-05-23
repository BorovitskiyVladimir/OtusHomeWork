using System;
using System.Collections.Generic;
using System.Text;

namespace OtusHomeWork.Interfaces
{
    public interface ITransactionParser
    {
        ITransaction Parse(string input);
    }
}
