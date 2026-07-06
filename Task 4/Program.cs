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


        }
    }
}

