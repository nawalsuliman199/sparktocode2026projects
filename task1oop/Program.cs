using System.Security.Principal;

namespace task1oop
{
    //class
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        public BankAccount() { }
        public BankAccount(int accountNumber ,string holderName,double balance )
            {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }
        public bool isoverdrawn
        {
            get { return Balance < 0; }
        }
        public void Deposit(double amount) { Balance += amount;
            SendEmail();
        }
        public void Withdraw (double amount) { 
            if (Balance >= amount)
                { 
                Balance -= amount;
                SendEmail();
            } 
            else {
                Console.WriteLine("Insufficient balance. ");
                    }
        }
        public double CheckBalance() {
            PrintInformation();
            return Balance;
        }
        private void PrintInformation() {
            Console.WriteLine("Holder Name :"+HolderName);
            Console.WriteLine("Balance : "+Balance);
        }
        private void SendEmail() {
            Console.WriteLine(" Email notification sent .");
        }

    }
    public class Student 
    {
    public string Name { get; set; }
    public string Address { get; set; }
    public int  Grade { get; set; }
        private string email;
        private int  age;
        private static int studentCount = 0;
        private string pin;
        public Student()
        {
            studentCount++;
        }
        public static int GetStudentCount()
        {
            return studentCount;
        }
        public string SecurityPIN
        {
            set
            {
                pin = value;
            }
        }
        public void Register( string Email ) {
            email = Email;
            SendEmail();
        }
        private void SendEmail() {
            Console.WriteLine("Registration email sent . ");
        }

    }
    public class Product 
    {
       public string ProductName { get; set; }
       public double Price { get; set; }
       public int StockQuantity { get; set; }
        public void Restock(int quantity ) {
            StockQuantity += quantity;
            LogTransaction();
        }
        public void Sell(int quantity) {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock ");
            }
            LogTransaction();
        
        }
        public double GetInventoryValue() {
            PrintDetails();
                return Price * StockQuantity; }
        private void PrintDetails() {
            Console.WriteLine("product Name :"+ProductName);
            Console.WriteLine("Price "+Price);
            Console.WriteLine("Stock "+StockQuantity);

        }
        private void LogTransaction() {
            Console.WriteLine("Transaction logged .");
        }
}
public class Program
    {
        static BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "karim", Balance = 120 };
        static BankAccount account2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };
        static Student Student1= new Student { Name = "Ali", Address ="Muscat", Grade = 65};
        static Student Student2= new Student { Name ="Ahmed", Address ="Muscat", Grade = 70};
        static Product Product1= new Product { ProductName ="Wireless Mouse", Price =5.500, StockQuantity =50};
        static Product Product2 = new Product { ProductName ="Mechanical Keyboard", Price =15.750, StockQuantity =20};
       



        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("1.view account details ");
                Console.WriteLine("2.update student address ");
                Console.WriteLine("3.make a deposit  ");
                Console.WriteLine("4.make a withdraw ");
                Console.WriteLine("5.view product details ");
                Console.WriteLine("6.register a student ");
                Console.WriteLine("7.compare two account balances ");
                Console.WriteLine("8.restock product and stock level check ");
                Console.WriteLine("9. transfer between accounts  ");
                Console.WriteLine("10.update student grade  ");
                Console.WriteLine("11.student report card ");
                Console.WriteLine("12.account health  status ");
                Console.WriteLine("13.bulk sale with revenue calculation ");
                Console.WriteLine("14.scholarship eligibility check  ");
                Console.WriteLine("15.full balance top-up flow  ");
                Console.WriteLine("16.quick account opening  ");
                Console.WriteLine("17.total student counter  ");
                Console.WriteLine("18.overdrawn account check ");
                Console.WriteLine("19.set student security PIN ");
                Console.WriteLine("20.exit ");
                Console.WriteLine("choose an option :");



                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ViewAccountDetails();
                        break;
                    case 2:
                        UpdateStudentAddress();
                        break;
                    case 3:
                        MakeDeposit();
                        break;
                    case 4:
                        Makewithdraw();
                        break;
                    case 5:
                        ViewProductDetails();
                        break;

                    case 6:
                        RegisterStudent();
                        break;
                    case 7:
                        compareaccountbalances();
                        break;
                        case 8:
                        restockproduct();
                        break;
                    case 9: transferbetweenccounts();
                        break;
                    case 10: updatesudentgrade();
                        break;
                    case 11: studentreportcard();
                        break;
                    case 12: accounthealthstatus();
                        break;
                    case 13: bulksalewithrevenue();
                        break;
                    case 14: scholarshipeligibilitycheck(); 
                        break;
                    case 15: fullbalancetopupflow();
                        break;
                    case 16: quickaccountopening();
                        break;
                    case 17: totalstudentscounter();
                        break;
                    case 18: overdrawnaccountcheck();
                        break;
                    case 19: setstudentsecurityPIN(); 
                        break;
                    case 20:
                        exit = true;
                        Console.WriteLine("Goodbye !");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                

            }


            }

             }
            
            static BankAccount chooseaccount ()
            {
                Console.Write("Choose account (1 or 2 ): ");
                string input = Console.ReadLine();
                if (input == "2")
                {
                    return account2;
                }
                return account1;
            }
            
            static Student choosestudent()
            {
                Console.Write("Choose student (1 or 2): " );
                
                string input = Console.ReadLine();
                if (input == "2")
                {
                    return Student2;
                }
                return Student1;
            }
            
            static Product chooseproduct()
            {
                Console.Write("Choose product (1 or 2 ): ");
                string input = Console.ReadLine();
                if (input == "2")
                {
                    return Product2;
                }
                return Product1;
            }
        static void ViewAccountDetails()
        {
            Console.Write("choose account (1 or 2 ): ");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                double result = account1.CheckBalance();
                Console.WriteLine("Returned balance " + result);
            }
            else if (input == 2)
            {
                double result = account2.CheckBalance();
                Console.WriteLine("Returned balance " + result);

            }
            else
            {
                Console.WriteLine("Enter valid account number ");

            }
        }

            static void UpdateStudentAddress()
            {
            Student student = choosestudent();
            Console.Write("Enter new address : ");
            string address = Console.ReadLine();
            student.Address = address;
            Console.WriteLine("Address updated to :"+student.Address);

            }
        static void MakeDeposit() {
            BankAccount account = chooseaccount();
            Console.Write("Enter amount :");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
            Console.WriteLine("Holder Name : " + account.HolderName);
            Console.WriteLine("Update Balance " + account.Balance);
        }
       


            static void Makewithdraw()
            {
            BankAccount account= chooseaccount();
            Console.Write("Enter amount : ");
            double amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
            Console.WriteLine("Update Balance : "+account.Balance);




            }
            static void ViewProductDetails()
            {
            Product product = chooseproduct();

            double value = product.GetInventoryValue();

            Console.WriteLine("Inventory Value: " + value);
        }
        static void RegisterStudent()
        {
            Student student = choosestudent();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            student.Register(email);

            Console.WriteLine("Student registered successfully.");
        }
        static void compareaccountbalances()
        {
            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine(account1.HolderName + " has the higher balance.");
            }
            else if (account2.Balance > account1.Balance)
            {
                Console.WriteLine(account2.HolderName + " has the higher balance.");
            }
            else
            {
                Console.WriteLine("Both accounts have the same balance.");
            }
        }

        static void restockproduct()
        {
            Product product = chooseproduct();

            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            product.Restock(quantity);

            if (product.StockQuantity < 10)
            {
                Console.WriteLine("Low");
            }
            else if (product.StockQuantity < 50)
            {
                Console.WriteLine("Moderate");
            }
            else
            {
                Console.WriteLine("Well Stocked");
            }
        }

        static void transferbetweenccounts()
        {
            Console.WriteLine("Choose source account");
            BankAccount source = chooseaccount();

            Console.WriteLine("Choose destination account");
            BankAccount destination = chooseaccount();

            Console.Write("Enter amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (source.Balance >= amount)
            {
                source.Withdraw(amount);
                destination.Deposit(amount);

                Console.WriteLine("Transfer completed.");
            }
            else
            {
                Console.WriteLine("Transfer failed. Not enough balance.");
            }
        }

        static void updatesudentgrade()
        {
            Student student = choosestudent();

            Console.Write("Enter new grade: ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 0 && grade <= 100)
            {
                student.Grade = grade;
                Console.WriteLine("Grade updated.");
            }
            else
            {
                Console.WriteLine("Invalid grade.");
            }
        }

        static void studentreportcard()
        {
            Student student = choosestudent();

            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Address: " + student.Address);
            Console.WriteLine("Grade: " + student.Grade);

            if (student.Grade >= 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        static void accounthealthstatus()
        {

            BankAccount account = chooseaccount();

            if (account.Balance < 50)
            {
                Console.WriteLine("Low Balance");
            }
            else if (account.Balance <= 1000)
            {
                Console.WriteLine("Healthy");
            }
            else
            {
                Console.WriteLine("Premium");
            }
        }

        static void bulksalewithrevenue()
        {
            Product product = chooseproduct();

            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            if (product.StockQuantity < quantity)
            {
                Console.WriteLine("Need " + (quantity - product.StockQuantity) + " more items.");
            }
            else
            {
                product.Sell(quantity);

                double revenue = quantity * product.Price;

                Console.WriteLine("Revenue: " + revenue);
            }
        }

        static void scholarshipeligibilitycheck()
        {
            Student student = choosestudent();
            BankAccount account = chooseaccount();

            if (student.Grade >= 80 && account.Balance >= 100)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }

        static void fullbalancetopupflow()
        {
            BankAccount account = chooseaccount();

            if (account.Balance < 50)
            {
                double before = account.Balance;

                double amount = 100 - account.Balance;

                account.Deposit(amount);

                Console.WriteLine("Before: " + before);
                Console.WriteLine("After: " + account.Balance);
            }
            else
            {
                Console.WriteLine("No top-up needed.");
            }
        }

        static void quickaccountopening()
        {
            Console.Write("Enter Account Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter Holder Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Balance: ");
            double balance = double.Parse(Console.ReadLine());

            BankAccount account = new BankAccount(number, name, balance);

            account.CheckBalance();
        }

        static void totalstudentscounter()
        {
            Console.WriteLine("Total Students: " + Student.GetStudentCount());
        }

        static void overdrawnaccountcheck()
        {
            BankAccount account = chooseaccount();

            if (account.isoverdrawn)
            {
                Console.WriteLine("Account is overdrawn.");
            }
            else
            {
                Console.WriteLine("Account is not overdrawn.");
            }
        }

        static void setstudentsecurityPIN()
        {
            Student student = choosestudent();

            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();

            student.SecurityPIN = pin;

            Console.WriteLine("PIN saved successfully.");
        }
    }




        }


        