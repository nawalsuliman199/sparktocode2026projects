namespace task4
{
    internal class Program
    {
        /// task 1
      
        
        static void printwecolme(string name)
        {
            Console.WriteLine("welcome " + name);
                }
        ///task 2
        static int square (int number)
        {
            return number * number;
        }
        /// task 3
        static double CelsiusToFahrenheit( double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        /// task 4
        static void DisplayMenu()
        {
            Console.WriteLine(" Menu ");
            Console.WriteLine(" 1.Start ");
            Console.WriteLine(" 2.Help ");
            Console.WriteLine(" 3.Exit ");

        }
        //task 5
        static bool IsEven(int num)
        {
            return numb % 2 == 0;
        }
        //task 6
        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

      
        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            printwecolme(name);
            ////task 2
            Console.Write("Enter a number ");
            int number =int.Parse(Console.
                ReadLine());
            int res = square(number);
            Console.WriteLine("square = " + res);
            //task 3
            Console.Write("Enter temerature in celsius :");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine("Temerature in fahrenheit = " + fahrenheit);
            //task 4
            DisplayMenu();
            Console.ReadLine();
            //task 5
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (IsEven(num))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            Console.ReadLine();
            //task 6 
            Console.Write("Enter the length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            double width = double.Parse(Console.ReadLine());

            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);

            Console.ReadLine();

        }
    }
}
