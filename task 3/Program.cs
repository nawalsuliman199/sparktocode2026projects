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



        }
    }
}
