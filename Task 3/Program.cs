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

        }
    }
}

