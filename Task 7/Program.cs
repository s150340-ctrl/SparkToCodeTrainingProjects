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
        //class guest
        public class Guest
        {
            public int guestId {  get; set; }
            public string guestName { get; set; }
            public int roomNumber {  set; get; }
            public DateTime checkInDate { set; get; }
            public int totalNights { set; get; }
            //constructer
            public Guest() { }
            public Guest(int id , string name , int room , DateTime date, int nights)
            {
                guestId = id;
                guestName = name;
                roomNumber = room;
                checkInDate = date;
                totalNights = nights;

            }
            //methods
            public void displayGuest()
            {
                Console.WriteLine("guest name : " + guestName);
                Console.WriteLine("guest id : " + guestId);
                Console.WriteLine("Checked in on : " + checkInDate);
                Console.WriteLine("Total nights : " + totalNights);
                Console.WriteLine("Room number : " + roomNumber);

            }
            public double calculateTotalCost(double amount)
            {
                return totalNights * amount;
            }

        }

        static void Main(string[] args)
        {
           
        }
    }
}
