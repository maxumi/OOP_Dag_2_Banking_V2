using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dag_2_Banking_V2
{
    internal class Data
    {
        static public List<Customer> CustomersList { get; set; } = new List<Customer>();
        static public List<Employee> EmployeesList { get; set; } = new List<Employee>();
        static public List<Account> AccountsList { get; set; } = new List<Account>();
        static public List<Transaction> TransactionsList { get; set; } = new List<Transaction>();
        public Data()
        {
            Customer C1 = new Customer()
            {
                Id = 1,
                Name = "Jake",
                Email = "TheBigJ@Gmail.com",
                Password = "The_Corret_pass"
            };
            Customer C2 = new Customer()
            {
                Id = 2,
                Name = "Mike",
                Email = "MikeBunchOfNumber@Gmail.com",
                Password = "MikeP"
            };
            Data.CustomersList.Add(C1);
            Data.CustomersList.Add(C2);
            Data.AccountsList.Add(new Account() { AccountID = 1, Balance = 1000, AccountnOwners = C1 });
            Data.AccountsList.Add(new Account() { AccountID = 2, Balance = 2000, AccountnOwners = C2 });
            Data.AccountsList.Add(new Account() { AccountID = 3, Balance = 3000, AccountnOwners = C2 });
            Employee E1 = new Employee()
            {
                Id = 1,
                Name = "Thomas",
                Email = "Thomas@gmail.com",
                Password = "BestEmploye"
            };
            Data.EmployeesList.Add(E1);
            Data.TransactionsList.Add(new Transaction() { TransactionID = 1, Date = DateTime.Now, Amount = 100, Type = "+", AccountData = Data.AccountsList[0] });
        }
    }
}
