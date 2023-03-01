using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dag_2_Banking_V2
{
    internal class Account
    {
        public int AccountID { get; set; }
        public int Balance { get; set; }
        public Customer AccountnOwners { get; set; }
        public static void SeeAccounts()
        {

            Console.Clear();
            foreach (Account account in Data.AccountsList)
            {
                Console.WriteLine("AccountID: " + account.AccountID + " Balance: " + account.Balance + " Owner: " + account.AccountnOwners.Name);
            }
        }
        public static void AddOrRemoveFromAccounts()
        {
            Console.WriteLine("Do you want to 'Add' or 'Remove' money from your account?");
            string Anwser = Console.ReadLine();
            if (Anwser == "Add")
            {
                SeeAccounts();
                Console.WriteLine("Write the accountID of the account you want to add money to");
                int AccountID = int.Parse(Console.ReadLine());
                foreach (Account account in Data.AccountsList)
                {
                    if (account.AccountID == AccountID)
                    {
                        Console.WriteLine("How much do you want to add?");
                        int Amount = int.Parse(Console.ReadLine());
                        account.Balance += Amount;
                        Transaction.TransactionData("+", account, Amount);
                        Program.StartMenu();
                    }
                }
            }
            else if (Anwser == "Remove")
            {
                SeeAccounts();
                Console.WriteLine("Write the accountID of the account you want to remove money from");
                int AccountID = int.Parse(Console.ReadLine());
                foreach (Account account in Data.AccountsList)
                {
                    if (account.AccountID == AccountID)
                    {
                        Console.WriteLine("How much do you want to remove?");
                        int Amount = int.Parse(Console.ReadLine());
                        account.Balance -= Amount;
                        Transaction.TransactionData("-", account, Amount);
                        Program.StartMenu();
                    }
                }
            }
        }

    }
}
