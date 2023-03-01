using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OOP_Dag_2_Banking_V2
{
    internal class Transaction
    {
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public string Type { get; set; }
        public Account AccountData { get; set; }
        public static void SeeAllTransactions()
        {
            Console.Clear();
            foreach (Transaction transaction in Data.TransactionsList)
            {
                Console.WriteLine("TransactionID: " + transaction.TransactionID + " Date: " + transaction.Date +" Type: "+transaction.Type + " Amount: " + transaction.Amount + " AccountID: " + transaction.AccountData.AccountID);
            }
        }
        public static void TransactionData(string type, Account account, int amount)
        {
            Data.TransactionsList.Add(new Transaction
            {
                TransactionID = Data.TransactionsList.Count +1,
                Date= DateTime.Now,
                Type= type,
                Amount= amount,
                AccountData= account

            }
                        );
        }
    }
}
