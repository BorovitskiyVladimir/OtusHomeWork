﻿using OtusHomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtusHomeWork.Classes
{
    public class Transfer : ITransaction
    {
        public ICurrencyAmount Amount { get; }
        public DateTimeOffset Date { get; }
        public string Destination { get; }
        public string Message { get; }
        public Transfer(ICurrencyAmount amount, DateTimeOffset date, string destination, string message)
        {
            Amount = amount;
            Date = date;
            Destination = destination;
            Message = message;
        }
        public override string ToString() => $"Перевод {Amount.Amount} {Amount.CurrencyCode} {Destination} {Message}";
    }
}
