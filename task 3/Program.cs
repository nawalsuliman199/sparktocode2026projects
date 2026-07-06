using System.Xml;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////
            ///task 1
            Console.Write("Enter a number x :");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter a number y :");
            double y = double.Parse(Console.ReadLine());
            double z = y - x;
            double result = Math.Abs(z);
            Console.WriteLine("final positive difference : " + result);
            ///////////////////////////////////
            ///task 2
            Console.Write("Enter a number  :");
            double num = double.Parse(Console.ReadLine());
            double res = Math.Pow(num,2);
            double ress = Math.Sqrt(num);
            Console.WriteLine("The square : " + res + " The  root square: " + ress);
            ////////////////////////////
            //////task 3
            Console.Write("Enter your full name : ");
            String name = Console.ReadLine();
            String toupper = name.ToUpper();
            String tolower = name.ToLower();
            int length = name.Length;
            Console.WriteLine("upper case " + toupper);
            Console.WriteLine("lower case " + tolower);
            Console.WriteLine("count " + length);
            //////////////////////
            ///task 4
            Console.Write("enter the number of days of a free trial : ");
            int days = int.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;
            DateTime enddate = today.AddDays(days);
            Console.WriteLine("Trial end date: " + enddate.ToString("yyyy-MM-dd"));
            ////////////////////
            ////task 5
            Console.Write("enter your exam score  :");
            double score = double.Parse(Console.ReadLine());
            double roundscore = Math.Round(score);
            Console.WriteLine("round score : " + roundscore);
            if (roundscore >= 60)
            {
                Console.WriteLine("PASS");
            }
            else {
                Console.WriteLine("FAIL");

            }
            ///////////////////////
            /////TASK 6 
            Console.Write("Enter your password : ");
            String password = Console.ReadLine();
            if (password.Length >= 8 && !password.ToLower().Contains("passowrd"))
            {
                Console.WriteLine("Strong password");
            }
            else
            {
                Console.WriteLine("weak passwoed");
                if (password.Length < 8)
                    Console.WriteLine("less than 8 characters ");
                if (password.ToLower().Contains("password"))
                    Console.WriteLine("contains the word 'password'  ");

            }
            ////////////////////////
            ///task 7
            Console.Write("Enter the first name: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter the second name: ");
            string name2 = Console.ReadLine();

            name1 = name1.Trim().ToUpper();
            name2 = name2.Trim().ToUpper();

            if (name1 == name2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }
            //////////////////////
            ////task9
            Console.Write("Enter a decimal number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Rounded: " + Math.Round(number));
            Console.WriteLine("Rounded Up: " + Math.Ceiling(number));
            Console.WriteLine("Rounded Down: " + Math.Floor(number));

            /////////////////
            ///task 10
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            if (sentence.Contains(word))
            {
                Console.WriteLine("First Position: " + sentence.IndexOf(word));
                Console.WriteLine("Last Position: " + sentence.LastIndexOf(word));
            }
            else
            {
                Console.WriteLine("Word not found");
            }
            ///////////////////////////////////////////
            //////task 11
            ///

            //////////////////
            ///////////task 12 
            Console.Write("Enter your birth date (yyyy-MM-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            int age = DateTime.Today.Year - birthDate.Year;

            if (DateTime.Today.Month < birthDate.Month ||
               (DateTime.Today.Month == birthDate.Month &&
                DateTime.Today.Day < birthDate.Day))
            {
                age--;
            }

            Console.WriteLine("Age: " + age);
            Console.WriteLine("Day of Birth: " + birthDate.DayOfWeek);


        }
    }
}
