using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
            Console.WriteLine("Which account do you want to transfer from and to?");
            Console.Write("From: ");
            int accountID1 = int.Parse(Console.ReadLine());
            bool truecheck1 = false;
            Console.Write("To: ");
            int accountID2 = int.Parse(Console.ReadLine());
            bool truecheck2 = false;
            Console.WriteLine("How much do you want to transfer");
            Console.Write("Amount: ");
            int Amount = int.Parse(Console.ReadLine());
            foreach (Account accountFrom in Data.AccountsList)
            {
                if (accountFrom.AccountID == accountID1){
                    truecheck1 = true;
                    foreach (Account accountTo in Data.AccountsList)
                    {
                        if (accountTo.AccountID == accountID2)
                        {
                            truecheck2 = true;
                            if (truecheck1 == true && truecheck2 == true)
                            {
                                accountFrom.Balance -= Amount;
                                accountTo.Balance += Amount;
                                Transaction.TransactionData("-", accountFrom, Amount);
                                Transaction.TransactionData("+", accountTo, Amount);
                                Console.WriteLine("Transfer complete");
                            }
                        }
                    }
                }
            }
        }
    }
}
