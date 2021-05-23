using Microsoft.Extensions.Caching.Memory;
using OtusHomeWork.Classes;
using OtusHomeWork.Repository;
using System;
using System.Diagnostics;
using System.Net.Http;

namespace OtusHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение для личного финансового учета");
            Trace.Listeners.Add(new ConsoleTraceListener());
            var currencyConverter = new ExchangeRatesApiConverter(new HttpClient(), new MemoryCache(new MemoryCacheOptions()), "a5cf9da55cb835d0a633a7825b3aa8b5");
            var transactionParser = new TransactionParser();
            var transactionRepository = new FileTransactionRepository("transactions.txt", transactionParser);
            var budgetApp = new BudjetApplication(transactionRepository, transactionParser, currencyConverter);
            budgetApp.OutputTransactions();
            budgetApp.OutputBalanceInMainCurrencies();
            var flagContinue = true;
            while (flagContinue)
            {
                Console.WriteLine("Введите 1 - для ввода новой транзакции, 2 - вывести транзакции, 0 - Выход");
                var key = Console.ReadKey();
                Console.WriteLine();
                if (key.KeyChar == '0')
                {
                    flagContinue = false;
                }
                else if (key.KeyChar == '1')
                {
                    Console.WriteLine("Введите транзакцию для учета (Операция(Трата/Перевод/Зачисление),Сумма, Валюта, Описание): ");
                    Console.WriteLine("Пример: Трата -15,00 USD Бензин ГазПромНефть ");                    
                    var input = Console.ReadLine();
                    budgetApp.AddTransaction(input);
                    budgetApp.OutputBalanceInMainCurrencies();

                }
                else if (key.KeyChar == '2')
                {
                    Console.WriteLine("Список транзакций:");
                    Console.WriteLine("======================");
                    budgetApp.OutputTransactions();
                    budgetApp.OutputBalanceInMainCurrencies();
                }
            }


        }


    }
}
