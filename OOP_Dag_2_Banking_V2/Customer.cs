using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dag_2_Banking_V2
{
    internal class Customer : Person
    {
        public void SeeCustomerAccounts()
        {
            Console.Clear();
            foreach (Account account in Data.AccountsList)
            {
                if (account.AccountnOwners == this)
                {
                    Console.WriteLine("AccountID: " + account.AccountID + " Balance: " + account.Balance);
                }
            }
        }
        public void TransferMoney()
        {
            Console.WriteLine("Which account do you want to transfer from?");
            int accountID1 = int.Parse(Console.ReadLine());
            bool truecheck1 = false;
            foreach (Account account in Data.AccountsList)
            {
                if (account.AccountID == accountID1)
                {
                    truecheck1 = true;
                }
            }
            Console.WriteLine("Which account do you want to transfer To?");
            int accountID2 = int.Parse(Console.ReadLine());
            bool truecheck2 = false;
            foreach (Account account in Data.AccountsList)
            {
                if (account.AccountID == accountID2)
                {
                    truecheck2 = true;
                }
            }
            if (truecheck1 && truecheck2 == true)
            {
                Console.WriteLine("How much do you want to transfer");
                int Amount = int.Parse(Console.ReadLine());
                foreach (Account account in Data.AccountsList)
                {
                    if (account.AccountID == accountID1)
                    {
                        account.Balance = account.Balance - Amount;
                        Transaction.TransactionData("-", account, Amount);
                    }
                }
                foreach (Account account in Data.AccountsList)
                {
                    if (account.AccountID == accountID2)
                    {
                        account.Balance = account.Balance + Amount;
                        Transaction.TransactionData("+", account, Amount);
                    }
                }
                this.SeeCustomerAccounts();
            }

        }
    }
}
