namespace task__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int[] grades = new int[5];
            for (int i =0;i<grades.Length;i++)
            {
                Console.Write("Enter grade "+(i+1));
                grades[i]= int.Parse(Console.ReadLine());

            }
            Console.WriteLine(" Student Grades ");
            foreach(int grade in grades)
                {
                Console.WriteLine(grade);
            }
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

















        }
    }
}
