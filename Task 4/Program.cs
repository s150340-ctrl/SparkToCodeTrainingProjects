using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace Task_4
{
    internal class Program
    {
        //so fixed an issuethere was a task that has similar functions justdifferent data type so nned overriding
        static string GetGradeLetter(int n)
        {
            if (n >= 90)
            {
                return "A";
            }
            else if (n >= 80)
            {
                return "B";
            }
            else if (n >= 70)
            {
                return "C";
            }
            else if (n >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }

        }
        static string GetGradeLetter(double n)
        {
            if (n >= 90)
            {
                return "A";
            }
            else if (n >= 80)
            {
                return "B";
            }
            else if (n >= 70)
            {
                return "C";
            }
            else if (n >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }

        }
        //create 3 overloaded functions (for task 9)
        static int Multiply(int n, int y)
        {
            return n * y;
        }
        static double Multiply(double n, double y)
        {
            return n * y;
        }
        static int Multiply(int n, int y, int z)
        {
            return n * y * z;
        }
        //create 2 overloaded functions (for task 10)
        static double CalculateArea(double n)
        {
            return n * n;
        }
        static double CalculateArea(double n, double x)
        {
            return n * x;
        }

        //functions for task 11
        static double Add(double x, double y) {
        
            return x + y;
        }
        static double Subtract(double x, double y)
        {

            return x - y;
        }
        static double MultiplyNumbers(double x, double y)
        {

            return x * y;
        }
        static double DivideNumbers(double x, double y)
        {
            try { double result = x / y;
                return result;
            
            } 
            catch(DivideByZeroException ex) // so apparantly  this wont happen because the numbers are double type it will just print infinity only if its int will it crash
            {
                return 0;
            }
           
        }
        static void DisplayResult(string name , double result)
        {
           Console.WriteLine("The result of "+ name +" is "+ result);
        }

        //functions for task 12(only 2 because 1 of them alreeady made)
        static void PrintReportCard(string name, double average,string grade) {

            Console.WriteLine("The student name: " + name);
            Console.WriteLine("The average : " + average);
            Console.WriteLine("The grade : " + grade);

        }

        static double CalculateAverage(double x, double y, double z) {

            return (x + y + z) / 3;

        }




        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Function
            Console.WriteLine();
            Console.WriteLine("Task 1 - Personalized Welcome Function");
            Console.WriteLine();
            string name = ""; //set name

            //welcome function
            static void PrintWelcome(string message) {

                Console.Write("Welcome "+ message);

            }

            while (true)
            {
                try
                {
                    Console.Write("Enter your name:");
                    name=Console.ReadLine();
                    PrintWelcome(name); //function prints name
                    break; //leave loop
                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }
            }


            //Task 2 - Square Number Function
            Console.WriteLine();
            Console.WriteLine("Task 2 - Square Number Function");
            Console.WriteLine();

            //function
            int Square(int n) {
             return Convert.ToInt32(Math.Pow(n, 2));
            }
            int number = 0; //just for now
            while (true)
            {
                try
                {
                    Console.Write("Enter a number:");
                    number = Convert.ToInt32(Console.ReadLine());
                    int numSquared = Square(number);
                    Console.WriteLine("The number square is "+ numSquared);



                    break; //leave loop
                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }
            }

            //Task 3 - Celsius to Fahrenheit Function
            Console.WriteLine();
            Console.WriteLine("Task 3 - Celsius to Fahrenheit Function");
            Console.WriteLine();
            //function
            double CelsiusToFahrenheit(double celsius) {


                return ((celsius * 9 / 5) + 32); //returns Fahrenheit value (double) 
            }
            //variables needed
            double celsius = 0;
            double fahrenheit = 0;
            //read from user
            while (true)
            {
                try
                {
                    Console.Write("Enter a Celsius value:");
                    celsius =double.Parse(Console.ReadLine());
                    fahrenheit=CelsiusToFahrenheit(celsius); //conversion happens
                    Console.WriteLine("The celsius value in fahrenheit:" + fahrenheit+" F");

                    break; //leave loop
                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }
            }


            //Task 4 - Fixed Menu Display Function
            Console.WriteLine();
            Console.WriteLine("Task 4 - Fixed Menu Display Function");
            Console.WriteLine();

            //function for display
            static void DisplayMenu(){
                Console.WriteLine("============");
                Console.WriteLine("1) Start");
                Console.WriteLine("2) Help");
                Console.WriteLine("3) Exit");
                Console.WriteLine("============");

            }

            //call to actually display menu
            DisplayMenu();


            //Task 5 - Even or Odd Function
            Console.WriteLine();
            Console.WriteLine("Task 5 - Even or Odd Function");
            Console.WriteLine();

            //function to check even or odd
            bool IsEven(int n)
            {
                if (n %2 == 0) return true;
                return false;//else it will return false
            }

            //now we ask user for a number
            while (true)
            {
                try
                {
                    Console.Write("Enter a number(int):");
                    int number5 = Convert.ToInt32(Console.ReadLine());
                    bool check = IsEven(number5); // checks value
                    if (check) { Console.WriteLine("number is even "); }
                    else
                    {
                        Console.WriteLine("number is odd");
                    }


                    break; //leave loop
                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }
            }

            //Task 6 - Rectangle Area & Perimeter Functions
            Console.WriteLine();
            Console.WriteLine("Task 6 - Rectangle Area & Perimeter Functions");
            Console.WriteLine();
            //two functions for computation
            //okay so i had a function here but in task 10 the same function was needed so
            //i ended up deleting this one because the function is literally the same thing
          

            double CalculatePerimeter(double length, double width)
            {
                return 2* (length * width);
            }

            //now we ask user
            while (true)
            {
                try
                {
                    Console.Write("Enter a length:");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter a width:");
                    double width = Convert.ToDouble(Console.ReadLine());
                    if ((length >= 0) && (width >= 0)) //just checking if poth are positive
                    {
                        double area = CalculateArea(length, width);
                        double perimeter = CalculatePerimeter(area, width);

                        Console.WriteLine("the area is " + area);
                        Console.WriteLine("the perimeter is " + perimeter);


                        break; //leave loop
                    }
                    Console.WriteLine("ERROR: Invalid input");//means maybe 1 of them atleast is negative 


                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }



            }


            //Task 7 - Grade Letter Function

            Console.WriteLine();
            Console.WriteLine("Task 7 - Grade Letter Function");
            Console.WriteLine();

            //function for gardes
            //had to put it outside so i can override this function
            /*
            string GetGradeLetter(int n)
            {
                if (n >= 90)
                {
                    return "A";
                }else if (n >= 80)
                {
                    return "B";
                }else if (n >= 70)
                {
                    return "C";
                }else if(n >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }

            }*/
            //now we ask user
            while (true)
            {
                try
                {
                    Console.Write("Enter your grade:");
                    int grade = Convert.ToInt32(Console.ReadLine());
                    string letterGrade = GetGradeLetter(grade);//gets grade
                    Console.WriteLine("Your final grade is "+ letterGrade);
                    break;//leave loop


                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }



            }


            //Task 8 - Countdown Function

            Console.WriteLine();
            Console.WriteLine("Task 8 - Countdown Function");
            Console.WriteLine();


            static void Countdown (int n)
            {
                for (int i = n; i > 0; i--)
                {
                    Console.WriteLine(i);
                }
            }

            //now we ask user
            while (true)
            {
                try
                {
                    Console.Write("Enter a starting number (int) :");
                    int start = Convert.ToInt32(Console.ReadLine());
                    Countdown(start); //countdown will print here
                    break;//leave loop


                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }



            }

            //Task 9 - Overloaded Multiply Function


            Console.WriteLine();
            Console.WriteLine("Task 9 - Overloaded Multiply Function");
            Console.WriteLine();

            //use all three sepreatly
            Console.WriteLine("Mutiplication of 2 integers 3 and 2 is " + Multiply(3, 2));
            Console.WriteLine("Mutiplication of 2 doubles 3.2 and 2.3 is " + Multiply(3.2, 2.3));
            Console.WriteLine("Mutiplication of 3 integers 3 and 2 and 5 is " + Multiply(3, 2, 5));


            //Task 10 - Overloaded Area Calculator


            Console.WriteLine();
            Console.WriteLine("Task 10 - Overloaded Area Calculator");
            Console.WriteLine();
            //ask user for shape
            while (true)
            {
                try
                {
                    Console.Write("Enter a shape (square/rectangle) :");
                    string shape = ((Console.ReadLine()).ToLower()).Trim();
                    if (shape == "square")
                    {
                        Console.Write("Enter a length :");
                        double length10 = Convert.ToInt32(Console.ReadLine());
                        //print and calculate area
                        Console.WriteLine("Area :"+ CalculateArea(length10));
                        break;

                    }else if (shape == "rectangle")
                    {
                        Console.Write("Enter a length :");
                        double length20 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter a width :");
                        double width20 = Convert.ToInt32(Console.ReadLine());
                        //print and calculate area
                        Console.WriteLine("Area :" + CalculateArea(length20, width20));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid shape.Try again.");
                    }





                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }



            }

            //Task 11 - Function-Based Calculator


            Console.WriteLine();
            Console.WriteLine("Task 11 - Function-Based Calculator");
            Console.WriteLine();
            //set variables
            string operation = "";
            double result = 0;
            double num1 = 0;
            double num2 = 0;
            //print menu 
            while (true)
            {
                try
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine("choose an option from the menu:");
                    Console.WriteLine("1) Addition");
                    Console.WriteLine("2)Subtraction");
                    Console.WriteLine("3)Multiplication");
                    Console.WriteLine("4)Division");
                    Console.WriteLine("5)Exit");
                    Console.Write("=====================================");
                    //read from user
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice != 5)
                    {
                        //only read 2 numbers for other numbers even if their not from option 
                        Console.Write("Enter the first number:");

                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second number:");

                        num2 = Convert.ToDouble(Console.ReadLine());


                    }
                    switch (choice)
                    {


                        case 1:
                            operation = "Addition";
                            result = Add(num1, num2);
                            DisplayResult(operation, result);
                            break;

                        case 2:
                            operation = "Subtraction";
                            result = Subtract(num1, num2);
                            DisplayResult(operation, result);
                            break;
                        case 3:
                            operation = "Multiplication";
                            result = MultiplyNumbers(num1, num2);
                            DisplayResult(operation, result);
                            break;
                        case 4:
                            operation = "Division";
                            result = DivideNumbers(num1, num2);
                            DisplayResult(operation, result);
                            break;
                        case 5:
                            Console.Write("Exiting....");
                            break;
                        default:
                            Console.WriteLine("That number isn't one of the options");
                            break;

                    }
                    //check if choice is 5
                    if (choice == 5)
                    {
                        break;// leave loop
                    }
                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }



































            }

            //Task 12 - Student Report Card Generator


            Console.WriteLine();
            Console.WriteLine("Task 12 - Student Report Card Generator");
            Console.WriteLine();
            //set variables
            double grade1 = 0;
            double grade2= 0;
            double grade3= 0;
            double finalResult = 0;

            //ask user
            while (true)
            {
                try
                {
                    Console.Write("Enter your name");
                    string name12= Console.ReadLine();
                    //now ask for grades
                    Console.WriteLine("Enter your 3 grades");
                    Console.Write("Enter your 1st grade");
                    grade1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter your 2nd grade");
                    grade2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter your 3rd grade");
                    grade3 = Convert.ToDouble(Console.ReadLine());
                    if ((grade1 >= 0) && (grade2 >= 0) && (grade3 >= 0))//checks if positive
                    {
                        finalResult = CalculateAverage(grade1, grade2, grade3);
                        string finalGrade = GetGradeLetter(finalResult);
                        //print report
                        PrintReportCard(name12, finalResult, finalGrade);
                        break;


                    }
                }
                catch (Exception ex)
                { Console.WriteLine("ERROR: Invalid input"); }
            }



        }











        
    }
}



