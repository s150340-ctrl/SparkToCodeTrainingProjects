using System.ComponentModel;
using System.Net.NetworkInformation;
using static Task_7.Program;

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
            public bool isAvailable { get; set; } = true;
            //instructers
            public Room()//defasult
            {

            }
            public Room(int number, string typeRoom, double priceNight)
            {
                roomNumber = number;
                roomType = typeRoom;
                pricePerNight = priceNight;
                
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
            public string guestId {  get; set; }
            public string guestName { get; set; }
            public string roomNumber { set; get; } = "Not Assigned";
            public DateTime checkInDate { set; get; }
            public int totalNights { set; get; }
            //constructer
            public Guest() { }
            public Guest(string id , string name , string room , DateTime date, int nights)
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
            //system lists
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();
            //add 6 room to rooms
            rooms.Add(new Room(1001, "single", 12.3));
            rooms.Add(new Room(1238, "double", 33));
            rooms.Add(new Room(1234, "suite",50.98));
            rooms.Add(new Room(5679, "single", 13.45));
            rooms.Add(new Room(1234, "double", 40.5));
            rooms.Add(new Room(1234, "suite", 100.5));

            //main loop

            //main menu
            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM\r\n");
                Console.WriteLine("================================================");
                Console.WriteLine(" 1. Add New Room");
                Console.WriteLine(" 2. Register New Guest");
                Console.WriteLine(" 3. Book a Room for a Guest");
                Console.WriteLine(" 4. View All Rooms ");
                Console.WriteLine(" 5. View All Guests");
                Console.WriteLine(" 6. Search & Filter Rooms");
                Console.WriteLine(" 7. Guest & Booking Statistics");
                Console.WriteLine(" 8. Update Room Price");
                Console.WriteLine(" 9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine(" 0. Exit");
                Console.WriteLine("================================================");
                Console.Write("Enter your choice: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1: AddRoom(rooms, guests); break;
                    case 2: RegisterGuest( guests); break;
                    case 3: BookRoom( rooms, guests); break;
                    case 4: MakeWithdrawal(); break;
                    case 5: ViewProductDetails(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareAccountBalances(); break;
                    case 8: RestockProduct(); break;
                    case 9: TransferBetweenAccounts(); break;
                    case 10: UpdateStudentGrade(); break;
                    case 11: StudentReportCard(); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenue(); break;
                    case 14: ScholarshipEligibilityCheck(); break;
                    case 15: FullBalanceTopUpFlow(); break;
                    case 0:
               
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }
                //after switch case 
                Console.WriteLine("\nPlease enter any key:");
                Console.ReadKey();
                Console.Clear();


            }
        }
        //add static methods
        static void AddRoom(List<Room> rooms, List<Guest> guests)
        {
            //ask user
            try
            {
                int pin = 0;
                while ((Convert.ToString(pin).Length < 4) && (pin <=0))
                {
                    Console.Write("Enter room number (must be 4 digits long):");
                    pin = Convert.ToInt32(Console.ReadLine());
                }
                string roomType = "";
                while ((roomType != "single") || (roomType != "double") || (roomType != "suite"))
                {
                    Console.Write("Enter room type (Single / Double / Suite):");
                    roomType =Console.ReadLine().ToLower();
                }
                double priceNight = -1;
                while (priceNight <= 0)
                {
                    Console.Write("Enter room price per night:");
                    priceNight = Convert.ToDouble(Console.ReadLine());
                }
                //check if room number exists
                bool exists = rooms.Any(r => r.roomNumber == pin);
                if (exists) { //it exists
                    Console.WriteLine("ERROR: room already exists.");

                }
                else
                {
                    rooms.Add(new Room(pin,roomType ,priceNight));
                    //message for last room added
                    rooms[-1].displayRoom();
                    Console.WriteLine("Updated room count: "+ rooms.Count);


                }

            }
            catch (Exception ex) { Console.WriteLine("ERROR: invalid input"); }

        }
        static void RegisterGuest( List<Guest> guests)
        {
            //generate a id for guest
            int number = guests.Count() +1;
            string id = "";
            //check size 
            if (number < 10)
            {
                id = "G00" + number;
            }
            else if ( number < 100)
            {
                id = "G0" + number;
            }
            else
            {
                id = "G" + number;
            }
            //now ask user for info
            try
            {
                Console.Write("Enter your name:");
                string name = Console.ReadLine();
                Console.Write("Enter check-in date as(11-02-2026):");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                int nightsStayed = -1;
                while (nightsStayed <= 0)
                {
                    Console.Write("Enter number of nights that you will stay for:");
                    nightsStayed = Convert.ToInt32(Console.ReadLine());
                }
                //now we add Guest
                Guest newGuest = new Guest();
                newGuest.guestName = name;
                newGuest.guestId = id;
                newGuest.checkInDate = date;
                newGuest.totalNights = nightsStayed;
                guests.Add(newGuest);
                //now we display information of guests
                guests[-1].displayGuest();
            }
            catch(Exception ex) { Console.WriteLine("ERROR: invalid input"); }

            

        }
        static void BookRoom(List<Room> rooms, List<Guest> guests)
        {
            //ask user 
            try
            {
                Console.Write("Enter your ID:");
                string id = Console.ReadLine();
                Console.Write("Enter room number you want to book:");
                int roomNum = Convert.ToInt32(Console.ReadLine());
                //now we check 
                Guest guest = guests.FirstOrDefault(g=> g.guestId == id);
                Room roomBook = rooms.FirstOrDefault(r => r.roomNumber == roomNum);
                if ((roomBook == null) || (guest == null)) {

                    Console.WriteLine("ERROR: invalid guest ID or room number");

                }
                else
                {
                    if (roomBook.isAvailable == true)
                    {
                       //now we add the room to gets roomNumber
                       guest.roomNumber = Convert.ToString(roomBook.roomNumber);
                        
                       //now we change the status of is available to false bec its booked
                       roomBook.isAvailable = false;
                       //now we print info
                        guest.displayGuest();
                        //print total cost
                        Console.WriteLine("Total cost :"+ guest.calculateTotalCost(roomBook.pricePerNight));


                    }
                    else
                    {
                        Console.WriteLine("Room is already booked");
                    }
                }
               

            }
            catch(Exception ex) 
            {
                Console.WriteLine("ERROR: invalid input"); }

        }
        static void ViewRooms(List<Room> rooms)
        {
            //first we check if the list empty
            if (rooms.Count() == 0)
            {
                Console.WriteLine("No rooms have been added yet");
            }
            else
            {
                int amountRooms = rooms.Count();
                Console.WriteLine("=====================================");
                Console.WriteLine("Total room count :" + amountRooms);
                Console.WriteLine("=====================================");

                //we make a new list that is sorted
                var sortedRooms = rooms.OrderBy(r => r.roomNumber).ToList();
                foreach (Room room in sortedRooms) {
                    room.displayRoom();
                }
            }
        }
    }
}
