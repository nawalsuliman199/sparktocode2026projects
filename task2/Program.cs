namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////
            ///task 1
            Console.Write("Enter starting number : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = num; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("lift off");
            /////////////////////
            ///task 2
            //Console.Write("Enter N :");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for ( int i =1;i<= n; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine("Sum :" + sum);

            ////////////////////////
            ///task 3
            //Console.Write("Enter number : ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i= 1;i<= 10; i++)
            //{
            //    Console.WriteLine(number + " x " + i + " = " + (number * i));
            //}

            /////////////////
            ///task 4
            //string password = "Spark 2026";
            //string input = "";
            //while (input != password)
            //{
            //    Console.Write("Enter password :");
            //    input= Console.ReadLine();
            //    if (input != password)
            //    {
            //        Console.WriteLine("Incorrect password, try again");
            //    }
            //    Console.WriteLine("Access Granted");
            //}
            ///////////////////////
            ///task 5
            //int secret = 42;
            //int guess;
            //int attempts = 0;

            //do
            //{
            //    Console.Write("Guess the number: ");
            //    guess = int.Parse(Console.ReadLine());
            //    attempts++;

            //    if (guess > secret)
            //    {
            //        Console.WriteLine("Too high");
            //    }
            //    else if (guess < secret)
            //    {
            //        Console.WriteLine("Too low");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Correct!");
            //    }

            //} while (guess != secret);

            //Console.WriteLine("Attempts: " + attempts);
            //////////////////////////////////////
            /////task 6
            //try
            //{
            //    Console.Write("Enter first number: ");
            //    double num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Enter second number: ");
            //    double num2 = Convert.ToDouble(Console.ReadLine());

            //    double result = num1 / num2;

            //    if (num2 == 0)
            //    {
            //        throw new DivideByZeroException();
            //    }

            //    Console.WriteLine("Result = " + result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero.");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid input.");
            //}
            //////////////////////////////////
            //////task 7
            //int choice = 0;

            //while (choice != 3)
            //{
            //    Console.WriteLine("1. Say Hello");
            //    Console.WriteLine("2. Greeting");
            //    Console.WriteLine("3. Exit");

            //    try
            //    {
            //        Console.Write("Choose: ");
            //        choice = int.Parse(Console.ReadLine());

            //        switch (choice)
            //        {
            //            case 1:
            //                Console.WriteLine("Hello!");
            //                break;

            //            case 2:
            //                Console.WriteLine("Good Day!");
            //                break;

            //            case 3:
            //                Console.WriteLine("Goodbye!");
            //                break;

            //            default:
            //                Console.WriteLine("Invalid choice.");
            //                break;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Please enter a valid number.");
            //    }

            //    Console.WriteLine();

            //}
            /////////////////////////////
            //////task 8
            ////Console.Write("Enter N: ");
            ////int n = int.Parse(Console.ReadLine());

            ////int sum = 0;

            ////for (int i = 1; i <= n; i++)
            ////{
            ////    if (i % 2 == 0)
            ////    {
            ////        sum += i;
            ////    }
            ////}

            ////Console.WriteLine("Sum = " + sum);
            /////////////////////////////
            //////task 9
            //int number = 0;
            //bool valid = false;

            //do
            //{
            //    try
            //    {
            //        Console.Write("Enter a positive number: ");
            //        number = int.Parse(Console.ReadLine());

            //        if (number > 0)
            //        {
            //            valid = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Number must be positive.");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Invalid input.");
            //    }

            //} while (!valid);

            //int sum = 0;

            //for (int i = 1; i <= number; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine("Sum = " + sum);
            ////////////////////////////////////////
            ////task 10 
            int pin = 1234;
            int attempts = 0;
            bool loggedIn = false;
            double balance = 100.000;

            while (attempts < 3 && !loggedIn)
            {
                try
                {
                    Console.Write("Enter PIN: ");
                    int input = int.Parse(Console.ReadLine());

                    if (input == pin)
                    {
                        loggedIn = true;
                    }
                    else
                    {
                        attempts++;
                        Console.WriteLine("Wrong PIN");
                    }
                }
                catch
                {
                    attempts++;
                    Console.WriteLine("Invalid PIN");
                }
            }

            if (!loggedIn)
            {
                Console.WriteLine("Card Blocked");
                return;
            }

            int choice = 0;

            while (choice != 4)
            {
                Console.WriteLine();
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                Console.Write("Choose: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.Write("Amount: ");
                            double amount = Convert.ToDouble(Console.ReadLine());

                            if (amount < 0)
                            {
                                Console.WriteLine("Invalid amount");
                            }
                            else
                            {
                                balance += amount;
                                Console.WriteLine("Balance = " + balance);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;

                    case 2:
                        try
                        {
                            Console.Write("Amount: ");
                            double amount = Convert.ToDouble(Console.ReadLine());

                            if (amount < 0)
                            {
                                Console.WriteLine("Invalid amount");
                            }
                            else if (amount > balance)
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                            else
                            {
                                balance -= amount;
                                Console.WriteLine("Balance = " + balance);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Balance = " + balance);
                        break;

                    case 4:
                        Console.WriteLine("Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }










        }
    }
}
