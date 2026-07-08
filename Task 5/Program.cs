namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Fixed Grades Array
            Console.WriteLine();
            Console.WriteLine("Task 1 - Fixed Grades Array");
            Console.WriteLine();
            //set an array
            int[] grades = new int[5];
            //read from user
            while (true)
            {
                try
                {
                    for (int i = 0; i < grades.Length; i++)
                    {
                        Console.Write("Enter your grades:");
                        grades[i] =int.Parse(Console.ReadLine());
                    }
                    //after we print 
                    Console.WriteLine("Your grades are:");
                    foreach (int x in grades)
                    {
                        Console.WriteLine(x);
                    }
                    //leave loop
                    break;
                }
                catch (Exception e) {
                    Console.WriteLine("Error invalid input.Try again.");


                }
            }
        }
    }
}
