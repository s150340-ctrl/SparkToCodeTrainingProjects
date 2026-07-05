using System.Net.Quic;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Absolute Difference
            Console.WriteLine();
            Console.WriteLine("Task 1 - Absolute Difference");
            Console.WriteLine();



            //ask user
            try
            {
                Console.Write("Enter the first number:");
                 int firstNum= Convert.ToInt32((string) Console.ReadLine());
                Console.Write("Enter the second number:");
                 int secondNum = Convert.ToInt32((string)Console.ReadLine());
                //compute difference
                Console.WriteLine("Absolute difference is:"+(Math.Abs(firstNum - secondNum)));
            

            }
            catch (Exception ex)
            { Console.WriteLine("that's not a valid number"); }

            //Task 2 - Power & Root Explorer
            Console.WriteLine();
            Console.WriteLine("Task 2 - Power & Root Explorer");
            Console.WriteLine();

            try
            {
                Console.Write("Enter a number:");
                double number = Convert.ToDouble((string)Console.ReadLine());
                //print its square
                Console.WriteLine(number +"square is :"+Math.Pow(number, 2));
                //print its square root
                Console.WriteLine(number + "square root is :" + Math.Sqrt(number));


            }
            catch (Exception ex)
            { Console.WriteLine("that's not a valid number"); }

            //Task 3 - Name Formatter
            Console.WriteLine();
            Console.WriteLine("Task 3 - Name Formatter");
            Console.WriteLine();

            while (true)
            {
                try
                {
                    Console.Write("Enter your full name:");
                    string fullName = Console.ReadLine();
                    if (fullName != "")
                    {
                        Console.WriteLine("Your full name in capital letters:"+fullName.ToUpper());
                        Console.WriteLine("Your full name in small letters:" + fullName.ToLower());
                        Console.WriteLine("Your name contains " + fullName.Length +" letters");
                        break;
                    }


                }
                catch (Exception ex)
                { Console.WriteLine("that's not a valid name"); }//this wont happen because all input are string
            }

            //Task 4 - Subscription End Date

            Console.WriteLine();
            Console.WriteLine("Task 4 - Subscription End Date");
            Console.WriteLine();
            //ask user
            DateTime date = DateTime.Today;
            int numDays = -1;

            while (true)
            {

                try
                {
                    Console.Write("Enter the number of days of a free trial:");
                     numDays =Convert.ToInt32( Console.ReadLine());
                    if (numDays>=0 )//user entered a valid number 
                    {
                        DateTime trailEnd = date.AddDays(numDays);
                        string trailEnds = trailEnd.ToString("yyyy-MM-dd");
                        Console.WriteLine("Trial ends at " + trailEnds);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a positive number");
                    }
                    


                }
                catch (Exception ex)
                { Console.WriteLine("that's not a valid number"); }
            }

            //Task 5 - Grade Rounding System

            Console.WriteLine();
            Console.WriteLine("Task 5 - Grade Rounding System");
            Console.WriteLine();
            //set varaibles to use
            double examScore = 0;

            //ask user
            while (true)
            {

                try
                {
                    Console.Write("Enter your raw exam score as a decimal number (e.g. 74.6):");
                    examScore = Convert.ToDouble(Console.ReadLine());
                    if (examScore >= 0)//user entered a valid number 
                    {
                        examScore = Math.Round(examScore);
                        if (examScore >= 60)
                        {
                            Console.WriteLine("You passed with a rounded score of :"+examScore);
                        }
                        else
                        {
                            Console.WriteLine("You failed with a rounded score of :" + examScore);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a positive number");
                    }



                }
                catch (Exception ex)
                { Console.WriteLine("that's not a valid number"); }
            }

            //Task 6 - Password Strength Checker

            Console.WriteLine();
            Console.WriteLine("Task 6 - Password Strength Checker");
            Console.WriteLine();
            string password = ""; //set varaible
            while (true)
            {
                Console.Write("Enter your password:");
                password = (Console.ReadLine()).ToLower();
                if((password.Length >=8) && !((password.Contains("password")))){

                    Console.WriteLine("The password "+ password+ " is strong");
                    break;
                }
                else
                {
                    if((password.Length< 8 )&& (password.Contains("password")))
                    {
                        Console.WriteLine("Your password is weak because it contains the word password and has less than 8 characters");
                    }else if (password.Length< 8){ 
                        
                        Console.WriteLine("Your password is weak because it has less than 8 characters");
                    }
                    else
                    {
                        Console.WriteLine("Your password is weak because it contains the word password");
                    }
                }
            }


        }
    }
}

