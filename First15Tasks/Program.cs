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

            if ((valid) && (userAge >= 18))
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

            if (celsius < 10)
            {
                weather = "Cold";
            } else if ((10 <= celsius) && (celsius <= 30))
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

            //Task 9 - Day Name Finder
            Console.WriteLine("");
            Console.WriteLine("Task 9 - Day Name Finder");
            Console.WriteLine("");
            //usr input
            Console.Write("enter a number from 1 to 7 (day of the week): ");
            int dayNum = Convert.ToInt32(Console.ReadLine());
            //based on num the day will be printed
            switch (dayNum)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2 :
                    Console.WriteLine("Monday");
                    break;
                case 3 : Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;

            }
            //Task 10 - Mini Calculator
            Console.WriteLine("");
            Console.WriteLine("Task 10 - Mini Calculator");
            Console.WriteLine("");
            //user input
            Console.Write("Enter the First number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Enter the operation symbol (+, -, *, /, or %): ");
            char operatorChar =char.Parse(Console.ReadLine());

            //preform computations
            switch (operatorChar) {
            
                case '+':
                    Console.WriteLine(firstNum + secondNum);

                    break;
                case '-':
                    Console.WriteLine(firstNum - secondNum);

                    break;
                case '*':
                    Console.WriteLine(firstNum - secondNum);

                    break;
                case '/':
                    if (secondNum != 0)
                    {
                        Console.WriteLine(firstNum / secondNum);
                    }
                    else { Console.WriteLine("Cannot divide by zero"); }

                    break;
                case '%':
                    if (secondNum != 0)
                    {
                        Console.WriteLine(firstNum % secondNum);
                    }
                    else { Console.WriteLine("Cannot divide by zero"); }


                    break;

                default:
                    Console.WriteLine("Invalid operator");

                    break;

                }

            //Task 11 - Loan Eligibility System
            Console.WriteLine("");
            Console.WriteLine("Task 11 - Loan Eligibility System");
            Console.WriteLine("");

            //check user age/income/loan
            Console.Write("Enter your age: ");
            int ageConfirm = Convert.ToInt32(Console.ReadLine());
            //income
            Console.Write("Enter your monthly income: ");
            int monthlyIncome = Convert.ToInt32(Console.ReadLine());
            //loan
            Console.Write("Do you have an existing loan (yes/no): ");
            string loanChck =Console.ReadLine();

            if(((ageConfirm>= 21)&& (ageConfirm <= 60)) && (monthlyIncome>= 400) && (loanChck == "no"))
            {
                Console.WriteLine("The user is eligible");
            }
            else
            {
                //this will only show 1 reason though not all 
                if(!((ageConfirm >= 21) && (ageConfirm <= 60)))
                {
                    Console.WriteLine("The age is out of range");
                }else if(!(monthlyIncome >= 400))
                {
                    Console.WriteLine("The income too low");
                }
                else
                {
                    Console.WriteLine("The user has an existing loan");
                }
            }
            //Task 12 - Shipping Cost Calculator
            Console.WriteLine("");
            Console.WriteLine("Task 12 - Shipping Cost Calculator");
            Console.WriteLine("");
            //user input
            //region
            Console.Write("Enter a region code ('A' for local, 'B' for national, 'C' for international): ");
            char region = char.Parse(Console.ReadLine());
            //weight
            Console.Write("Enter the package weight (in kg): ");
            double weight = double.Parse(Console.ReadLine());
            //set varaibles
            double baseCost = 0;
            double extraCharge = 0;
            //check cost
            switch (region)
            {

                case 'A':
                    baseCost=1;
                    if(weight > 5) { extraCharge += 2; }
                    else if (weight > 10) { extraCharge += 5; }
                    else { extraCharge = 0; }
                    Console.WriteLine("Base cost:"+ baseCost);
                    Console.WriteLine("Extra charge:" + extraCharge);
                    Console.WriteLine("Total shipping:" + (extraCharge+ baseCost));


                    break;
                case 'B':
                    baseCost = 3;
                    if (weight > 5) { extraCharge += 2; }
                    else if (weight > 10) { extraCharge += 5; }
                    else { extraCharge = 0; }
                    Console.WriteLine("Base cost:" + baseCost);
                    Console.WriteLine("Extra charge:" + extraCharge);
                    Console.WriteLine("Total shipping:" + (extraCharge + baseCost));


                    break;
                case 'C':
                    baseCost = 7;
                    if (weight > 5) { extraCharge += 2; }
                    else if (weight > 10) { extraCharge += 5; }
                    else { extraCharge = 0; }
                    Console.WriteLine("Base cost:" + baseCost);
                    Console.WriteLine("Extra charge:" + extraCharge);
                    Console.WriteLine("Total shipping:" + (extraCharge + baseCost));


                    break;
         

                default:
                    Console.WriteLine("Invalid region");

                    break;

            }

            //Task 13 - Triangle Type Classifier
            Console.WriteLine("");
            Console.WriteLine("Task 13 - Triangle Type Classifier");
            Console.WriteLine("");

            //triangle sides
            Console.Write("Enter the length of the first side: ");
            double firstSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the second side: ");
            double secSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the third side: ");
            double thirdSide = double.Parse(Console.ReadLine());

            //check if any combo is valid
            if((firstSide + secSide > thirdSide) || (firstSide + thirdSide > secSide) || (secSide + thirdSide > firstSide))
            {
                if ((firstSide == secSide) &&(secSide == thirdSide)) {

                    Console.WriteLine("The sides form an Equilateral triangle ");
                }else if( (firstSide == thirdSide) || (thirdSide==secSide) || (firstSide == secSide))
                {
                    Console.WriteLine("The sides form an Isosceles triangle");
                }
                else
                {
                    Console.WriteLine("The sides form a Scalene triangle");
                }
            }
            else
            {
                Console.WriteLine("The sides do not form a valid triangle");
            }










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
            //Task 15 - University Admission Decision
            Console.WriteLine("");
            Console.WriteLine("Task 15 - University Admission Decision");
            Console.WriteLine("");

            //user input
            Console.Write("Enter the program type ('S' for Science, 'A' for Arts): ");
            char programType = char.Parse(Console.ReadLine());

            //GPA
            Console.Write("Enter your GPA(out of 4): ");
            double GPA = double.Parse(Console.ReadLine());
            //examscore
            Console.Write("Enter your entrance exam score(out of 100): ");
            double examScore = double.Parse(Console.ReadLine());
            //achievement
            Console.Write("Do you have an extracurricular achievement (yes/no): ");
            string achievement = Console.ReadLine();
            //set variable
            string finalResult = "";




            switch (programType) {


                case 'S':
                    if((GPA>=3.0) && (examScore >= 75))
                    {
                        finalResult = "Admitted";
                    }else if (achievement == "yes") { finalResult = "Conditionally Admitted"; }
                    else{ finalResult = "Not Admitted"; }
                    Console.WriteLine("Program type: Science, Finals result:"+ finalResult);

                    break;
                case 'A':
                    if ((GPA >= 2.5) && (examScore >= 60))
                    {
                        finalResult = "Admitted";
                    }
                    else if (achievement == "yes") { finalResult = "Conditionally Admitted"; }
                    else { finalResult = "Not Admitted"; }
                    Console.WriteLine("Program type: Arts, Finals result:" + finalResult);
                    break;
                default:
                    Console.WriteLine("Invalid program type");
                    break;
            
            }
        }



    }















    }


















