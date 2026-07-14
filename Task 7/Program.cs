namespace Task_7
{
    internal class Program
    {
        //making the classes 
        public class Room
        {
            public int roomNumber {  get; set; }
            public string roomType { get; set; }
            public double pricePerNight { get; set; }
            public bool isAvailable { get; set; }
            //instructers
            public Room()//defasult
            {

            }
            public Room(int number, string typeRoom, double priceNight, bool available)
            {
                roomNumber = number;
                roomType = typeRoom;
                pricePerNight = priceNight;
                isAvailable = available;
            }


            
                //methods
            public void displayRoom()
            {
                Console.WriteLine("Room number : " + roomNumber);
                Console.WriteLine("Room type : " + roomType);
                Console.WriteLine("Room price per night : " + roomType);
                Console.WriteLine("Room status (available?) : " + isAvailable);

            }
            

            

        }

        static void Main(string[] args)
        {
           
        }
    }
}
