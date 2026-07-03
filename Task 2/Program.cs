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

            for(int i = number; i !=0; i--)
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


            for (int i = 1; i<= wholeNum; i++)
            {
                sum+=i;
            }
            Console.WriteLine("Final sum :"+sum);


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
                Console.WriteLine(i+"x"+ num3+"="+(i* num3));

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

        }
    }
}
