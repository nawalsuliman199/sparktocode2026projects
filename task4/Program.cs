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

            
        }
    }
}
