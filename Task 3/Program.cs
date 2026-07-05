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
                Console.WriteLine(number +" square is :"+Math.Pow(number, 2));
                //print its square root
                Console.WriteLine(number + " square root is :" + Math.Sqrt(number));


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
                { Console.WriteLine("that's not a valid name"); }//this wont happen because all input are string only if null refrence
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



            //Task 7 - Clean Name Comparator

            Console.WriteLine();
            Console.WriteLine("Task 7 - Clean Name Comparator");
            Console.WriteLine();

            string checkName = ""; //set varaible
            string checkName2 = "";
            while (true)
            {
                Console.Write("Enter your name:");
                checkName = ((Console.ReadLine()).ToLower()).Trim();
                Console.Write("Enter your name again:");
                checkName2 = ((Console.ReadLine()).ToLower()).Trim();

                if (checkName == checkName2)
                {
                    Console.WriteLine("Match");

                    break;
                }
                else
                {
                    Console.WriteLine("No Match");
                }
            }

            //Task 8 - Membership Expiry Checker

            Console.WriteLine();
            Console.WriteLine("Task 8 - Membership Expiry Checker");
            Console.WriteLine();

            //set varaible
            DateTime now = DateTime.Today;
            while (true)
            {
                try
                {
                    Console.Write("Enter your membership start date as text (e.g. \"2026-01-10\"):");
                    DateTime membershipStart = DateTime.Parse(Console.ReadLine());
                    Console.Write("Enter the number of valid membership days: ");
                    int membershipDays =Convert.ToInt32(Console.ReadLine());
                    DateTime expiryDate = membershipStart.AddDays(membershipDays);
                    if(expiryDate >= now) {
                        Console.WriteLine("membership is Active ,Expiry date:"+ expiryDate.ToString("yyyy-MM-dd"));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("membership is Expired ,Expiry date:" + expiryDate.ToString("yyyy-MM-dd"));
                        break;
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine("That is not a valid value");
                }

            }

            //Task 9 - Round Up / Round Down Explorer

            Console.WriteLine();
            Console.WriteLine("Task 9 - Round Up / Round Down Explorer");
            Console.WriteLine();
            //ask user for input
            double number9 = 0;
            while (true)
            {
                try
                {
                    Console.Write("Entera a decimal number:");
                    number9 = Convert.ToDouble(Console.ReadLine());
                    //print 3 different roundings of it
                    Console.WriteLine("nearest whole number "+Math.Round(number9));
                    Console.WriteLine("always rounded up " + Math.Ceiling(number9));
                    Console.WriteLine("always rounded down " + Math.Floor(number9));
                    break;



                }
                catch (Exception ex)
                {
                    Console.WriteLine("That is not a valid value");
                }

            }

            //Task 10 - Word Position Finder

            Console.WriteLine();
            Console.WriteLine("Task 10 - Word Position Finder");
            Console.WriteLine();
            //keep reading from user until valid input
            while(true) {

                try
                {
                    Console.Write("Entera a  full sentence :");
                    string fullSentance =Console.ReadLine();
                    Console.Write("Entera a word to search for :");
                    string word = Console.ReadLine();
                    //check if sentance contains word
                    if(fullSentance.Contains(word) ){
                        //check index location
                        //first occurance
                        Console.WriteLine("First-occurrence position at index "+ fullSentance.IndexOf(word));
                        //last ocuurance
                        Console.WriteLine("Last-occurrence position at index " + fullSentance.LastIndexOf(word));
                        break; //exit program

                    }
                    else
                    {
                        Console.WriteLine("not found");
                        break;
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error : invalid input");






            }









        }
    }
}
}



