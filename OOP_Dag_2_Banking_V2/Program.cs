namespace OOP_Dag_2_Banking_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();//Creates all the premade data
            StartMenu();
        }
        public static void StartMenu()
        {
            Console.Clear();
            Console.WriteLine("Login");
            Console.WriteLine("1. Customer\n2. Employe");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Login for Customer");
                    Console.Write("Email: ");
                    string emailChecker = Console.ReadLine();
                    Console.Write("Passoword: ");
                    string passwordChecker = Console.ReadLine();
                    foreach (Customer customer in Data.CustomersList)
                    {
                        if (customer.Email == emailChecker && customer.Password == passwordChecker)
                        {
                            Console.WriteLine("Welcome, " + customer.Name);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("1. See Accounts\n2. Transfer Money\n3. Add or Remove from accounts");
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
                                    Console.ReadLine();
                                    break;
                                case ConsoleKey.D3:
                                    Account.AddOrRemoveFromAccounts();
                                    break;
                                default:
                                    break;
                            }
                        }

                    }
                    break;
                case ConsoleKey.D2:
                    //Switch for employe
                    Console.WriteLine("Login for Employee");
                    Console.Write("Email: ");
                    string emailChecker2 = Console.ReadLine();
                    Console.Write("Passoword: ");
                    string passwordChecker2 = Console.ReadLine();
                    foreach (Employee employee in Data.EmployeesList)
                    {
                        if (employee.Email == emailChecker2 && employee.Password == passwordChecker2)
                        {
                            Console.WriteLine("Welcome, " + employee.Name);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("1. See All Customers\n2. Create Accounts/Customers\n3. Add or Remove from accounts\n4. Tranactions.");
                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.D1:
                                    Employee.SeeAllCustomers();
                                    Console.ReadLine();
                                    break;
                                case ConsoleKey.D2:
                                    employee.Create_Accounts__Or_Customers();
                                    Console.ReadLine();
                                    break;
                                case ConsoleKey.D3:
                                    Account.AddOrRemoveFromAccounts();
                                    break;
                                case ConsoleKey.D4:
                                    Transaction.SeeAllTransactions();
                                    Console.ReadLine();
                                    StartMenu();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}