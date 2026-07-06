namespace Task_4
{
    internal class Program
    {
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


        }
    }
}

