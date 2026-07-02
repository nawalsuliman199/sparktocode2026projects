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
            /////////////////////
            ///task 8
            //Console.Write("Enter the total bill : ");
            //double bill = double.Parse(Console.ReadLine());
            //Console.Write("Are you a loyalty member ? (yes/no): ");
            //string answer = Console.ReadLine();
            //bool member = answer== "yes";
            //if (bill >20 && member)
            //{ double discount = bill * 0.15;
            //    double finalBill = bill - discount;
            //    Console.WriteLine("Original Bill "+bill+" OMR");
            //    Console.WriteLine("Discount "+discount+" OMR");
            //    Console.WriteLine("Final Bill "+finalBill+" OMR");

            //}
            //else
            //{
            //    Console.WriteLine("Original Bill " + bill + " OMR");
            //    Console.WriteLine("Discount = 0 OMR");
            //    Console.WriteLine("fianl  Bill " + bill + " OMR");
            //}
            ////////////////////
            ///task 9
            Console.Write("Enter a number 1-7 : ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thusrday");
                    break;
                case 6:
                    Console.WriteLine("friday");
                    break;
                case7:
                    Console.WriteLine("Sturday");
                    break;
                default:
                    Console.WriteLine(" Invaild");
                    break;


            }
            ////task 13
            Console.Write("Enter side 1: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Enter side 2: ");
            double side2 = double.Parse(Console.ReadLine());

            Console.Write("Enter side 3: ");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 + side2 > side3 &&
                side1 + side3 > side2 &&
                side2 + side3 > side1)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Scalene");
                }
            }
            else
            {
                Console.WriteLine("Invalid triangle");
            }


            ////task 14
            Console.Write("Enter product code (1-3): ");
            int code = int.Parse(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Do you have a discount coupon? (yes/no): ");
            string answer = Console.ReadLine();

            bool coupon = answer == "yes";

            double price = 0;

            switch (code)
            {
                case 1:
                    price = 8.500;
                    break;

                case 2:
                    price = 12.000;
                    break;

                case 3:
                    price = 5.000;
                    break;

                default:
                    Console.WriteLine("Invalid product code");
                    return;
            }

            double subtotal = price * quantity;
            double discount = 0;

            if (coupon && subtotal > 20)
            {
                discount = subtotal * 0.10;
            }

            double afterDiscount = subtotal - discount;
            double tax = afterDiscount * 0.05;
            double total = afterDiscount + tax;

            Console.WriteLine("Subtotal: " + subtotal + " OMR");
            Console.WriteLine("Discount: " + discount + " OMR");
            Console.WriteLine("Tax: " + tax + " OMR");
            Console.WriteLine("Final Total: " + total + " OMR");








        }

        }
    }


