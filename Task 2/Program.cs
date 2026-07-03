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

            

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i+"x"+ num3+"="+(i* num3));

            }




    }
    }
}
