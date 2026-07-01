using System.Globalization;
using System.Reflection.Metadata;

namespace First15Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1Personal Info Card
            //I will use the same info as the sample output
            Console.WriteLine("Task1-Personal Info Card");
            Console.WriteLine("");
            //declaring info
            string name = "Sara";
            int age = 21;
            double height = 1.65;
            bool student = true;
            //printing
            Console.WriteLine("Name: "+ name +", Age: "+age +", Height: "+ height+ ", Student: "+student);

            //Task 2 - Rectangle Calculator
            Console.WriteLine("");
            Console.WriteLine("Task 2 - Rectangle Calculator");
            Console.WriteLine("");
            Console.Write("Enter the width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter the length: ");
            double length = double.Parse(Console.ReadLine());
            //compute area/perimeter
            double area = length * width;
            double perimeter = 2 * (length + width);
            //print results
            Console.WriteLine("");
            Console.WriteLine("Area: " + area + ", Perimeter: " + perimeter);

            //Task 3 - Even or Odd Checker
            Console.WriteLine("");
            Console.WriteLine("Task 3 - Even or Odd Checker");
            Console.WriteLine("");

            //asking user
            Console.Write("Enter a whole number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //checking
            if (num%2 == 0) {
                Console.Write("the number "+num + " is even");
            }
            else {
                Console.Write("the number " + num + " is odd");

            }


            //Task 4 - Voting Eligibility
            Console.WriteLine("");
            Console.WriteLine("Task 4 - Voting Eligibility");
            Console.WriteLine("");

            //asking user for age
            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            //asking for valid national ID
            Console.Write("Do you hold a valid national ID (yes/no): ");
            string validId = Console.ReadLine();
            bool valid;
            //converting from yes/no to bool

            if (validId == "yes") { valid = true; }
            else {valid = false; }
            //checking eligiblility

            if ((valid )&&(userAge >18))
            {
                Console.WriteLine("The person is eligible to vote.");

            }
            else { Console.WriteLine("The person is not eligible to vote."); }

            //Task 5 - Grade Letter Lookup
            Console.WriteLine("");
            Console.WriteLine("Task 5 - Grade Letter Lookup");
            Console.WriteLine("");

            //askign user to enter char rep a grade
            Console.Write("Enter a single character representing a grade ('A', 'B', 'C', 'D', or 'F'): ");
            char grade = char.Parse(Console.ReadLine());

            switch(grade)
            {

                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;


            }
            //MEDIUM (5 Tasks)

            //Task 6 - Temperature Converter
            Console.WriteLine("");
            Console.WriteLine("Task 6 - Temperature Converter");
            Console.WriteLine("");

            //reading temp

            Console.Write("enter a temperature in Celsius: ");
            double celsius= double.Parse(Console.ReadLine());

            //converting Celsius to  Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            //Classification
            string weather;

            if (fahrenheit < 10)
            {
                weather = "Cold";
            }else if ((10<= fahrenheit)&&( fahrenheit<=30))
            {
                weather = "Mild";
            }
            else
            {
                weather = "Hot";
            }

            //print info 
            Console.WriteLine("the weather is " + weather + ", the temperature is " + fahrenheit +"F");


            //Task 7 - Movie Ticket Pricing
            Console.WriteLine("");
            Console.WriteLine("Task 7 - Movie Ticket Pricing");
            Console.WriteLine("");

            //user input
            Console.Write("Enter your age :");
            int ageMovie =Convert.ToInt32(Console.ReadLine());

            //ticket cost
            double ticket;
            //category
            string category;
            if ((0 <= ageMovie) && (ageMovie <= 12))
            {
                ticket = 2;
                category = "Children";
            }
            else if ((13 <= ageMovie) && (ageMovie <= 59))
            {
                ticket = 5;
                category = "Adults";
            }
            else
            {
                ticket = 3;
                category = "Seniors";
            }
            //print all info
            Console.WriteLine("Ticket category: "+ category+", Price :"+ ticket +" OMR");













        }














    }
    }

