namespace task__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //int[] grades = new int[5];
            //for (int i =0;i<grades.Length;i++)
            //{
            //    Console.Write("Enter grade "+(i+1));
            //    grades[i]= int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine(" Student Grades ");
            //foreach(int grade in grades)
            //    {
            //    Console.WriteLine(grade);
            //}
            //task 2
            List <string> todolist = new List<string>(); 
            for (int i =0; i<5;i++)
            {
                Console.Write("Enter task " + (i + 1));
                todolist.Add(Console.ReadLine());
            }
            Console.WriteLine(" your to do list ");
            foreach (string task in todolist) { 
                Console.WriteLine(task);
            }
            //task 3
            Stack<string> history= new Stack<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter website"+(i+1));
                history.Push(Console.ReadLine());
            }
            history.Pop();
            Console.WriteLine("current page :" + history.Peek());
            //task 4
            Queue<string> customer  = new Queue<string>();
            for (int i=0;i<3;i++)
            {
                Console.Write("Enter customer " + (i + 1));
                customer.Enqueue(Console.ReadLine());

            }
            string servedCustomer = customer.Dequeue();

            Console.WriteLine("erved customer: " + servedCustomer);
            //task 5
            int[] grades = new int[5];
            int sum = 0;
            for (int i= 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade "+(i+1));
                grades[i]=int.Parse(Console.ReadLine());

            }
            Array.Sort(grades);
            for (int i = 0; i < grades.Length; i++)
            {
                sum+= grades[i];
            }
            double average = (double)sum / grades.Length;

            Console.WriteLine("Lowest Grade: " + grades[0]);
            Console.WriteLine("Highest Grade: " + grades[grades.Length - 1]);
            Console.WriteLine("Average Grade: " + average);

            //task 6
            List<string> shopping = new List<string>();

            while (true)
            {
                Console.Write("Enter item: ");
                string item = Console.ReadLine();

                if (item == "done")
                {
                    break;
                }

                shopping.Add(item);
            }

            Console.WriteLine("Shopping List:");
            foreach (string item in shopping)
            {
                Console.WriteLine(item);
            }

            Console.Write("Enter item to remove: ");
            string remove = Console.ReadLine();

            shopping.Remove(remove);

            Console.WriteLine("After Remove:");
            foreach (string item in shopping)
            {
                Console.WriteLine(item);
            }
            //task 7
            List<int> scores = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter score: ");
                scores.Add(int.Parse(Console.ReadLine()));
            }

            scores.Sort();
            scores.Reverse();

            Console.WriteLine("1st Place: " + scores[0]);
            Console.WriteLine("2nd Place: " + scores[1]);
            Console.WriteLine("3rd Place: " + scores[2]);













        }
    }
}
