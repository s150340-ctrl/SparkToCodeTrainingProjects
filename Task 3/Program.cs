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



        }
    }
}

