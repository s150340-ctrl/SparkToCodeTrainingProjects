using System.Diagnostics.Metrics;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1 - Countdown Timer
            Console.WriteLine("");
            Console.WriteLine("Task 1 - Countdown Timer");
            Console.WriteLine("");

            //user input
            Console.Write("Enter a starting number(int):");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = number; i != 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");

            //Task 2 - Sum of Numbers 1 to N
            Console.WriteLine("");
            Console.WriteLine("Task 2 - Sum of Numbers 1 to N");
            Console.WriteLine("");

            //set varaible sum
            int sum = 0;
            //user input
            Console.Write("Enter a positive whole number N:");
            int wholeNum = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= wholeNum; i++)
            {
                sum += i;
            }
            Console.WriteLine("Final sum :" + sum);


            //Task 3 - Multiplication Table
            Console.WriteLine("");
            Console.WriteLine("Task 3 - Multiplication Table");
            Console.WriteLine("");

            //user input
            Console.Write("Enter a positive whole number N:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            //print time table

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + "x" + num3 + "=" + (i * num3));

            }

            //Task 4 - Password Retry
            Console.WriteLine("");
            Console.WriteLine("Task 4 - Password Retry");
            Console.WriteLine("");
            //password
            string code = "Spark2026";
            Console.WriteLine("Enter the password:");
            string check = Console.ReadLine();
            while (check != code)
            {
                Console.WriteLine("Incorrect password, try again");
                Console.WriteLine("Enter the password:");
                check = Console.ReadLine();

            }
            Console.WriteLine("Access Granted");


            //Task 5 - Number Guessing Game
            Console.WriteLine("");
            Console.WriteLine("Task 5 - Number Guessing Game");
            Console.WriteLine("");

            int counter = 0;
            int secretNum = 42;
            int numGuess = 0;


            //loop body
            do
            {
                Console.WriteLine(" Guess the number:");
                numGuess = Convert.ToInt32(Console.ReadLine());
                counter++;
                if (numGuess < secretNum) { Console.WriteLine("Too low"); }
                else if (numGuess > secretNum) { Console.WriteLine("Too high"); }
                else { Console.WriteLine("Correct!"); }
            } while (secretNum != numGuess);


            //Task 6 - Safe Division Calculator
            Console.WriteLine("");
            Console.WriteLine("Task 6 - Safe Division Calculator");
            Console.WriteLine("");
            //ask user to enter 2 numbers
            try
            {

                Console.WriteLine("Enter the first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine(num1 / num2);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("We cannot divide by zero");

            }
            catch (Exception ex) { Console.WriteLine("Input is not a valid number"); }


            //Task 7 - Repeating Menu with Exit Option
            Console.WriteLine("");
            Console.WriteLine("Task 7 - Repeating Menu with Exit Option");
            Console.WriteLine("");

            //printing menu 
            string quit = "";

            while (quit != "Q")
            {
                try
                {
                    //keep printing menu
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Please select an option :");
                    Console.WriteLine("1) Say Hello ");
                    Console.WriteLine("2) Say Good morning ");
                    Console.Write("3) Exit ");
                    int menuChoice = Convert.ToInt32(Console.ReadLine());
                    //choice
                    switch (menuChoice)
                    {
                        case 1:
                            Console.WriteLine("Hello");
                            break;
                        case 2:
                            Console.WriteLine("Good morning");
                            break;
                        case 3:
                            quit = "Q";
                            break;
                        default:
                            Console.WriteLine("That number isnt one of the options");
                            break;

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(" ERROR :Thats not a number");
                }


            }


            //Task 8 - Sum of Even Numbers Only
            Console.WriteLine("");
            Console.WriteLine("Task 8 - Sum of Even Numbers Only");
            Console.WriteLine("");


            //set varaible sum
            int sumEven = 0;
            //user input
            Console.Write("Enter a positive whole number N:");
            int wholeNumN = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= wholeNumN; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += i;
                }
            }
            Console.WriteLine("Final sum :" + sumEven);

            //Task 9 - Validated Positive Number Input
            Console.WriteLine("");
            Console.WriteLine("Task 9 - Validated Positive Number Input");
            Console.WriteLine("");

            //set positive number
            int positiveNum = 0; // only did this so compiler runs my code
            bool checker = true;
            do
            {
                try
                {
                    Console.Write("Enter a positive whole number N:");
                    positiveNum = Convert.ToInt32(Console.ReadLine());
                    //checks if its zero or negative
                    if (positiveNum > 0) //we check here
                    {
                        checker = false; //this will break the loop when a positive number is entered
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("ERROR :That's not a valid positve number");
                }
            } while (checker);


            int amount = 0;
            //here we will do the printing
            for (int i = 1; i <= positiveNum; i++)
            {
                amount += i;
            }
            Console.WriteLine("Final sum :" + amount);



            //Task 10 - Simple ATM Simulation
            Console.WriteLine("");
            Console.WriteLine("Task 10 - Simple ATM Simulation");
            Console.WriteLine("");

            //set variables
            int fixedPin = 1234;
            double balance = 100.0;
            int attempts = 3;
            int tries = 0;
            int pin = 0;

            do
            {
                try
                {
                    Console.Write("Enter PIN:");
                    pin = Convert.ToInt32(Console.ReadLine());
                    tries++;
                    if (pin != fixedPin)
                    {
                        Console.WriteLine("Wrong PIN");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong PIN");
                    tries++;
                }

            } while ((tries != attempts) && (pin != fixedPin));

            if (pin != fixedPin)
            {
                Console.WriteLine("Card Blocked");
            }
            else
            {
              
                string stop = "";

                while (stop != "Q")
                {


                    //keep printing menu
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Please select an option :");
                    Console.WriteLine("1) Deposit");
                    Console.WriteLine("2) Withdraw");
                    Console.Write("3) Check Balance ");
                    Console.Write("4) Exit ");
                    int menuNum = Convert.ToInt32(Console.ReadLine());
                    //read choices and catch error
                    try
                    {
                        switch (menuNum)
                        {
                            case 1:
                                Console.Write("Enter amount to deposit");
                                double deposit = Convert.ToDouble(Console.ReadLine());
                                if (deposit <=0)
                                {
                                    Console.Write("Invalid amount to deposit");

                                }
                                else
                                {
                                    balance += deposit; //add to balance
                                    Console.WriteLine("Your balance is :" + balance);
                                }

                                break;
                            case 2:
                                Console.Write("Enter amount to withdraw");
                                double withdraw = Convert.ToDouble(Console.ReadLine());
                                if ((withdraw <= 0) || (withdraw >balance))
                                {
                                    Console.Write("Invalid amount to withdraw");

                                }
                                else
                                {
                                    balance-= withdraw; //deduct from balance
                                    Console.WriteLine("Your balance is :" + balance);
                                }
                                break;
                            case 3:
                                Console.WriteLine("Your balance is :"+balance);
                                break;
                            case 4:
                                stop = "Q";
                                break;
                            default:
                                Console.WriteLine("That number isnt one of the options");
                                break;

                        }

                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Invalid input");
                    }



                }

















            }
        }
    }
}
    
    




