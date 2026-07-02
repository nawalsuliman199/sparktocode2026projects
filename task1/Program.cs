using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            //String Name = "Nawal ";
            //int age = 23;
            //double hieght = 1.89;
            //bool isStudent = true;
            //Console.WriteLine("Name is :" + Name);
            //Console.WriteLine("Age is :" + age);
            //Console.WriteLine("Hieght is :" + hieght);
            //Console.WriteLine("Student  :" + isStudent);
            ////////////////////////////////////////////////////////////

            ////task 2
            //Console.Write("Enter the length  rectangle ");
            //Double length = double.Parse(Console.ReadLine());
            //Console.Write("Enter the width  rectangle ");
            //Double width = double.Parse(Console.ReadLine());
            //double Area = length * width;
            //double Perimeter = 2 * (length + width);
            //Console.WriteLine("Area :" + Area);
            //Console.WriteLine("Perimeter :" + Perimeter);

            ////////////////////////
            ////task 3

            //Console.Write("Enter a whole number ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("it is even number ");
            //}
            //else
            //{
            //    Console.WriteLine("it is odd number ");
            //}


            ///////////////////////////////////
            /////task 4
            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write("Do you have a valid national ID? (yes/no): ");
            //string answer = Console.ReadLine();

            //bool hasID = answer == "yes";

            //if (age >= 18 && hasID)
            //{
            //    Console.WriteLine("You are eligible to vote.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to vote.");
            //}
            ///////////////////////////////
            /////task 5
            //Console.Write("Enter your grade (A, B, C, D, F): ");
            //char grade = char.Parse(Console.ReadLine());

            //switch (grade)
            //{
            //    case 'A':
            //        Console.WriteLine("Excellent");
            //        break;

            //    case 'B':
            //        Console.WriteLine("Very Good");
            //        break;

            //    case 'C':
            //        Console.WriteLine("Good");
            //        break;

            //    case 'D':
            //        Console.WriteLine("Pass");
            //        break;

            //    case 'F':
            //        Console.WriteLine("Fail");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid grade");
            //        break;
            //}
            //////////////////////////////////
            /////task 6
            //Console.Write("temperature in Celsius");
            //double Celsius = double.Parse(Console.ReadLine());
            //double Fahrenheit = (Celsius * 9 / 5) + 32;
            //Console.WriteLine("Fahrenheit : " + Fahrenheit);
            //if (Celsius < 10)
            //{
            //    Console.WriteLine("COLD");
            //}

            //else if (Celsius <= 30)
            //{
            //    Console.WriteLine("MILD");
            //}
            //else 
            //{
            //    Console.WriteLine("HOT");
            //}
            /////////////////
            ////task 7
            ///
            Console.Write("Enter your age :");
            int age = int.Parse(Console.ReadLine());
             if (age == 0 && age ==12 )
            {
                Console.WriteLine("Category :   Children ");
                Console.WriteLine(" Ticket price: 2 OMR");

            }
            else if (age >= 13 && age <= 59)
            {
                Console.WriteLine("Category: Adult");
                Console.WriteLine("Ticket Price: 5 OMR");
            }
            else
            {
                Console.WriteLine("Category: Senior");
                Console.WriteLine("Ticket Price: 3 OMR");
            }









        }

        }
    }


