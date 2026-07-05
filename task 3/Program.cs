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

        }
    }
}
