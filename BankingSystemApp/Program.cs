namespace BankingSystemApp
{
    internal class Program
    {
        static List<string> customerNameS = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;
            while(!exitApp){
                Console.WriteLine("welcome ");
                Console.WriteLine("1.Add New account ");
                Console.WriteLine("2.Deposit money ");
                Console.WriteLine("3.Withdraw Money");
                Console.WriteLine("4.Show Balance");
                Console.WriteLine("5.Transfer Amount");
                Console.WriteLine("6.List All Accounts");
                Console.WriteLine("7.Close Account");
                Console.WriteLine("8.Exit");

                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;

                    case 2:
                        DepositMoney();
                        break;

                    case 3:
                        WithdrawMoney();
                        break;

                    case 4:
                        ShowBalance();
                        break;

                    case 5:
                        TransferAmount();
                        break;

                    case 6:
                        ListAllAccounts();
                        break;

                    case 7:
                        CloseAccount();
                        break;

                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }



            }
        }
        static void AddAccount()
        {
            Console.Write("Enter  customer name : ");
            string name = Console.ReadLine();
            Console.Write("Enter account number :");
            string account = Console.ReadLine();
            if (accountNumbers.Contains(account))
            {
                Console.WriteLine("Account number already exists .");
                return;

            }
            Console.Write("Enter starting balance :");
            double balance = double.Parse(Console.ReadLine());
            if (balance < 0)
            {
                Console.WriteLine("Balance connot be negative.");
                return;

            }
            customerNameS.Add(name);
            accountNumbers.Add(account);
            balances.Add(balance);

            Console.WriteLine("Account addes successfully .");
            Console.WriteLine("Customer :" + name);
            Console.WriteLine("Account Number " + account);
            Console.WriteLine("Balance " + balance);
        }   

        static void DepositMoney()
        {
            Console.Write("Enter account number :");
            string account = Console.ReadLine();
            int index = accountNumbers.IndexOf(account);
            if (index==-1)
            {
                Console.WriteLine("Account not found ");
                return;
            }
            Console.Write("Enter deposit amount :");
            double amount = double.Parse(Console.ReadLine());
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero");
                return;
            }
            balances[index] = balances[index] + amount;

            Console.WriteLine("Deposit successful.");
            Console.WriteLine("New Balance: " + balances[index]);


        }

        static void WithdrawMoney()
        {

        }

        static void ShowBalance()
        {

        }

        static void TransferAmount()
        {

        }

        static void ListAllAccounts()
        {

        }

        static void CloseAccount()
        {

        }
    }
}
