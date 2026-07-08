namespace task4
{
    internal class Program
    {
        static void printwecolme(string name)
        {
            Console.WriteLine("welcome " + name);
                }

        static void Main(string[] args)
        {
            Console.Write("Enter your name");
            string name = Console.ReadLine();

            printwecolme(name);
        }
    }
}
