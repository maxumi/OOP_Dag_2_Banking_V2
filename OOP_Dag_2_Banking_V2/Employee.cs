using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dag_2_Banking_V2
{
    internal class Employee : Person
    {
        public  static void SeeAllCustomers()
        {
            Console.Clear();
            foreach (Customer customer in Data.CustomersList)
            {
                Console.WriteLine("ID: " + customer.Id + " Name: " + customer.Name + " Email: " + customer.Email);
            }
            Console.ReadLine();
        }
        public void Create_Accounts__Or_Customers()
        {
            Console.WriteLine("Do you want to create a Accounts or Customers?");
            string Anwser = Console.ReadLine();
            if (Anwser == "Accounts")
            {
                Console.WriteLine("Write the name of the owner");
                string Name = Console.ReadLine();
                foreach (Customer customer in Data.CustomersList)
                {
                    if (customer.Name == Name)
                    {
                        Console.WriteLine("What is the balance of the account");
                        int Balance = int.Parse(Console.ReadLine());
                        Data.AccountsList.Add(new Account
                        {
                            AccountID = Data.AccountsList.Count + 1,
                            Balance = Balance,
                            AccountnOwners = customer
                        }
                        );
                        Account.SeeAccounts();
                        Console.ReadLine();
                    }
                }
            }
            else if (Anwser == "Customers")
            {
                Console.WriteLine("Write the name of the customer");
                string Name = Console.ReadLine();
                Console.WriteLine("Write the email of the customer");
                string Email = Console.ReadLine();
                Console.WriteLine("Write the password of the customer");
                string Password = Console.ReadLine();
                Data.CustomersList.Add(new Customer
                {
                    Id = Data.CustomersList.Count + 1,
                    Name = Name,
                    Email = Email,
                    Password = Password
                }
                );
                SeeAllCustomers();
                Console.ReadLine();
                Menu.StartMenu();
            }
        }
    }
}
