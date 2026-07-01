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
            Console.WriteLine("Name: " + name + ", Age: " + age + ", Height: " + height + ", Student: " + student);

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
            if (num % 2 == 0) {
                Console.Write("the number " + num + " is even");
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
            else { valid = false; }
            //checking eligiblility

            if ((valid) && (userAge > 18))
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

            switch (grade)
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
            double celsius = double.Parse(Console.ReadLine());

            //converting Celsius to  Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            //Classification
            string weather;

            if (fahrenheit < 10)
            {
                weather = "Cold";
            } else if ((10 <= fahrenheit) && (fahrenheit <= 30))
            {
                weather = "Mild";
            }
            else
            {
                weather = "Hot";
            }

            //print info 
            Console.WriteLine("the weather is " + weather + ", the temperature is " + fahrenheit + "F");


            //Task 7 - Movie Ticket Pricing
            Console.WriteLine("");
            Console.WriteLine("Task 7 - Movie Ticket Pricing");
            Console.WriteLine("");

            //user input
            Console.Write("Enter your age :");
            int ageMovie = Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine("Ticket category: " + category + ", Price :" + ticket + " OMR");


            //Task 8 - Restaurant Bill with Membership Discount
            Console.WriteLine("");
            Console.WriteLine("Task 8 - Restaurant Bill with Membership Discount");
            Console.WriteLine("");

            //set variables
            double discountAmount = 0;
            const double discount = 0.15;

            //input
            // total bill amount
            Console.Write("Enter the total bill amount: ");
            double bill = double.Parse(Console.ReadLine());
            //loyalty member
            Console.Write("are you a loyalty member(yes / no): ");
            string loyaltyMem = Console.ReadLine();
            if ((loyaltyMem == "yes") && (bill > 20)) {
                discountAmount = bill * discount;


            }
            //print bill info
            Console.WriteLine("Original bill: " + bill + ",Discount amount:" + discountAmount + ", Final amount:" + (bill - discountAmount));


            //i will be skipping task 9-13 and 15 because of the repetitve nature of the code + save time, all the ideas are the same no matter the difficulty
            //im also skipping because i have things i need to do so im sorry in-advance i try my best to fulfil all the tasks faithfully and do what i can with the the 
            // time constraint !




            //task 14
            Console.WriteLine("");
            Console.WriteLine("Task 14 - Online Store Checkout");
            Console.WriteLine("");

            //first print menu for user
            Console.WriteLine("--------------------------------");
            Console.Write("Enter a product code(1 for Headphones , 2 for Keyboard and 3 for Mouse): ");
            int code = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do you  have a discount coupon (yes/no).");
            string coupon = Console.ReadLine();
            //set variables
            double discounts = 0.1;
            double unitPrice= 0; // just so no error shows for defualt case
            double tax = 0.05;
            bool stop = false;
            double discountedA = 0;
            double taxAmount = 0;

            switch (code) {


                case 1:
                    unitPrice = 8.5;
                    break;
                case 2:
                    unitPrice = 12;
                    break;
                case 3:
                    unitPrice = 5;
                    break;
                default:
                    Console.WriteLine("Invalid product code");
                    stop = true; // means we dont calculate anything
                    break;



            }
            if (!stop)// this to ensure that the calculation and everything will happen only when valid codes are entered
            {
                double subtotal = unitPrice * quantity;

                if ((subtotal > 20) && (coupon == "yes"))
                {
                    discountedA = discounts * subtotal;
                    //amoutnt after discount * tax to get tax amount
                    taxAmount = (subtotal - discountedA) * tax;

                }

                double finalTotal = subtotal - discountedA + taxAmount;


                //print everything now
                Console.WriteLine("subtotal :" + subtotal );
                Console.WriteLine("Discount amount:" + discountedA);
                Console.WriteLine("tax amount:" + taxAmount );
                Console.WriteLine("Final amount:" + finalTotal);
               



            }


        } 















    }
}

















