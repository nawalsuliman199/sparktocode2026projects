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

        }

        static void DepositMoney()
        {

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
