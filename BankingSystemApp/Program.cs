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
            Console.Write("Enter account number: ");
            string account = Console.ReadLine();

            int index = accountNumbers.IndexOf(account);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter withdraw amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero.");
                return;
            }

            if (amount > balances[index])
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            balances[index] = balances[index] - amount;

            Console.WriteLine("Withdraw successful.");
            Console.WriteLine("New Balance: " + balances[index]);

        }

        static void ShowBalance()
        {
            Console.Write("Enter account number: ");
            string account = Console.ReadLine();

            int index = accountNumbers.IndexOf(account);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.WriteLine("Customer Name : " + customerNameS[index]);
            Console.WriteLine("Account Number: " + accountNumbers[index]);
            Console.WriteLine("Balance       : " + balances[index]);
        }
        

        static void TransferAmount()
        {
            Console.Write("Enter sender account number: ");
            string senderAccount = Console.ReadLine();

            Console.Write("Enter receiver account number: ");
            string receiverAccount = Console.ReadLine();

            int senderIndex = accountNumbers.IndexOf(senderAccount);
            int receiverIndex = accountNumbers.IndexOf(receiverAccount);

            if (senderIndex == -1)
            {
                Console.WriteLine("Sender account not found.");
                return;
            }

            if (receiverIndex == -1)
            {
                Console.WriteLine("Receiver account not found.");
                return;
            }

            if (senderIndex == receiverIndex)
            {
                Console.WriteLine("Cannot transfer to the same account.");
                return;
            }

            Console.Write("Enter transfer amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero.");
                return;
            }

            if (amount > balances[senderIndex])
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            balances[senderIndex] -= amount;
            balances[receiverIndex] += amount;

            Console.WriteLine("Transfer successful.");
            Console.WriteLine("Sender New Balance: " + balances[senderIndex]);
            Console.WriteLine("Receiver New Balance: " + balances[receiverIndex]);
        }

        static void ListAllAccounts()
        {
            if (accountNumbers.Count == 0)
            {
                Console.WriteLine("No accounts available.");
                return;
            }

            Console.WriteLine(" All Accounts ");

            for (int i = 0; i < accountNumbers.Count; i++)
            {
                Console.WriteLine("Customer : " + customerNameS[i]);
                Console.WriteLine("Account  : " + accountNumbers[i]);
                Console.WriteLine("Balance  : " + balances[i]);
            }
        }

        static void CloseAccount()
        {

            Console.Write("Enter account number to close: ");
            string account = Console.ReadLine();

            int index = accountNumbers.IndexOf(account);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.WriteLine("Closing account of " + customerNameS[index]);

            customerNameS.RemoveAt(index);
            accountNumbers.RemoveAt(index);
            balances.RemoveAt(index);

            Console.WriteLine("Account closed successfully.");
        }
    }
}
