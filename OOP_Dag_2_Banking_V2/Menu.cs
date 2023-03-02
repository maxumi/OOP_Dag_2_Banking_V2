using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dag_2_Banking_V2
{
    internal class Menu
    {
        //things from startmenu but now put here
        public static void StartMenu()
        {
            Console.WriteLine("Welcome to the bank");
            Console.WriteLine("1. Log in as customer");
            Console.WriteLine("2. Log in as employee");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    LogInCustomer();
                    break;
                case ConsoleKey.D2:
                    LogInEmployee();
                    break;
                default:
                    break;
            }

            void LogInCustomer()
            {
                Console.Write("Enter your email: ");
                string email = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                foreach (Customer customer in Data.CustomersList)
                {
                    if (customer.Email == email && customer.Password == password)
                    {
                        Console.WriteLine("Welcome " + customer.Name);
                        Console.WriteLine("1. See Accounts.");
                        Console.WriteLine("2. Transfer Money.");
                        Console.WriteLine("3. Add or Remove from accounts.");
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.D1:
                                customer.SeeCustomerAccounts();
                                Console.ReadLine();
                                StartMenu();
                                break;
                            case ConsoleKey.D2:
                                customer.SeeCustomerAccounts();
                                customer.TransferMoney();
                                StartMenu();
                                Console.ReadLine();
                                break;
                            case ConsoleKey.D3:
                                Account.AddOrRemoveFromAccounts();
                                break;
                            default:
                                break;
                        }
                    }
                    Console.WriteLine("Wrong input");
                    Console.ReadKey();
                    Console.Clear();
                    StartMenu();
                }
            }

            void LogInEmployee()
            {
                Console.Write("Enter your email: ");
                string email = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                foreach (Employee employee in Data.EmployeesList)
                {
                    if (employee.Email == email && employee.Password == password)
                    {
                        Console.WriteLine("Welcome " + employee.Name);
                        Console.WriteLine("1. See All Customers");
                        Console.WriteLine("2. Create Accounts/Customers");
                        Console.WriteLine("3. Add or Remove from accounts");
                        Console.WriteLine("4. Tranactions.");
                        Console.WriteLine("5. See All Accounts");
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.D1:
                                Employee.SeeAllCustomers();
                                StartMenu();
                                break;
                            case ConsoleKey.D2:
                                employee.Create_Accounts__Or_Customers();
                                Console.Clear();
                                StartMenu();
                                break;
                            case ConsoleKey.D3:
                                Console.Clear();
                                Account.AddOrRemoveFromAccounts();
                                StartMenu();
                                break;
                            case ConsoleKey.D4:
                                Transaction.SeeAllTransactions();
                                Console.ReadKey();
                                Console.Clear();
                                StartMenu();
                                break;
                            case ConsoleKey.D5:
                                Account.SeeAccounts();
                                Console.ReadKey();
                                Console.Clear();
                                StartMenu();
                                break;
                            default:
                                break;
                        }
                    }
                }
                Console.WriteLine("Wrong input");
                Console.ReadKey();
                Console.Clear();
                StartMenu();
            }
        }
    }
}
