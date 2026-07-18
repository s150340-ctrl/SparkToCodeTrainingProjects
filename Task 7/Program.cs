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
                Console.WriteLine("Room price per night : " + pricePerNight);
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
            public double calculateTotalCost(List<Room> rooms)
            {
               if (roomNumber == "Not Assigned") {  return 0; }
               //else we get the room
               int myRoomNum = int.Parse(roomNumber);
               Room myRoom = rooms.FirstOrDefault(r => r.roomNumber == myRoomNum);
                if (myRoom == null) { return 0; }
                else
                {
                    return myRoom.pricePerNight * totalNights;
                }
                



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
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 15.");
                    continue;
                }

                switch (choice)
                {
                    case 1: AddRoom(rooms, guests); break;
                    case 2: RegisterGuest( guests); break;
                    case 3: BookRoom( rooms, guests); break;
                    case 4: ViewRooms(rooms); break;
                    case 5: ViewGuests(guests); break;
                    case 6: SearchFilter(rooms); break;
                    case 7: GuestBooking(rooms, guests); break;
                    case 8: UpdateRoomPrice(rooms); break;
                    case 9: GuestLookUp( guests); break;
                    case 10: RoomTypeBreakDown( rooms); break;
                    case 11: GuestCheckOut( rooms, guests); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenue(); break;
                    case 14: ScholarshipEligibilityCheck(); break;
                    case 15: FullBalanceTopUpFlow(); break;
                    case 0:
               
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 15.");
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
                string name = Console.ReadLine().ToLower();
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
                        Console.WriteLine("Total cost :"+ guest.calculateTotalCost(rooms));


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
        static void ViewGuests(List<Guest> guests)
        {
            //first we check if the list empty
            if (guests.Count() == 0)
            {
                Console.WriteLine("No rooms have been added yet");
            }
            else
            {
                int amountguests = guests.Count();
                Console.WriteLine("=====================================");
                Console.WriteLine("Total room count :" + amountguests);
                Console.WriteLine("=====================================");

                //we make a new list that is sorted
                var sortedGuests = guests.OrderBy(g => g.guestName).ToList();
                foreach (Guest guest in sortedGuests)
                {
                    guest.displayGuest();
                }
            }
        }
        static void SearchFilter(List<Room> rooms)
        {
            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("Menu for Searching & Filtering Rooms");
                Console.WriteLine("================================================");
                Console.WriteLine(" 1. Show all available rooms");
                Console.WriteLine(" 2. Filter by room type");
                Console.WriteLine(" 3. Filter by max price");
                Console.WriteLine(" 4. Room price statistics");
                Console.WriteLine(" 0. Back");
                Console.WriteLine("================================================");
                Console.Write("Enter your choice: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        //get all rooms where is avaialble is true
                        var isAvailable = rooms.Where(r => r.isAvailable == true).ToList();
                        if (isAvailable.Count() != 0)
                        {
                            isAvailable = isAvailable.OrderBy(r => r.pricePerNight).ToList();
                            Console.WriteLine("Number of available rooms :" + isAvailable.Count());
                            foreach (Room room in isAvailable)
                            {
                                room.displayRoom();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No rooms found for the selected criteria");
                        }

                        break;
                    case 2:
                        try
                        {
                            //ask user for room type
                            string roomType = "";
                            while ((roomType != "single") || (roomType != "double") || (roomType != "suite"))
                            {
                                Console.Write("Enter room type (Single / Double / Suite):");
                                roomType = Console.ReadLine().ToLower();
                            }
                            //get all rooms with same type
                            var roomTypes = rooms.Where(r => r.roomType == roomType).ToList();
                            if (roomTypes.Count() != 0)
                            {
                                Console.WriteLine("Number of rooms  with similar type :" + roomTypes.Count());
                                foreach (Room room in roomTypes)
                                {
                                    room.displayRoom();
                                }
                            }
                            else
                            {
                                Console.WriteLine("No rooms found for the selected criteria");
                            }

                        }
                        catch (Exception e) { Console.WriteLine("Invalid input"); continue; }


                        break;
                    case 3:
                        //get maximum price
                        try
                        {
                            //ask user for price
                            double price = -1;
                            while (price <= 0)
                            {
                                Console.Write("Enter maximum price:");
                                price = int.Parse(Console.ReadLine());
                            }
                            //get all rooms with same price
                            var roomsPriced = rooms.Where(r => r.pricePerNight <= price).ToList();
                            if (roomsPriced.Count() != 0)
                            {
                                roomsPriced = roomsPriced.OrderBy(r => r.pricePerNight).ToList();
                                Console.WriteLine("Number of rooms  with similar type :" + roomsPriced.Count());
                                foreach (Room room in roomsPriced)
                                {
                                    room.displayRoom();
                                }
                            }
                            else
                            {
                                Console.WriteLine("No rooms found for the selected criteria");
                            }


                        }
                        catch (Exception e) { Console.WriteLine("Invalid input"); continue; }




                        break;
                    case 4:
                        //display room info
                        Console.WriteLine("Number of rooms :" + rooms.Count());
                        var availableRooms = rooms.Where(r => r.isAvailable == true).ToList();
                        Console.WriteLine("Number of available rooms :" + availableRooms.Count());
                        Console.WriteLine("Average price of rooms :" + rooms.Average(r => r.pricePerNight));
                        Console.WriteLine("Cheapest priced room :" + rooms.Min(r => r.pricePerNight));
                        Console.WriteLine("Cheapest priced room :" + rooms.Max(r => r.pricePerNight));



                        break;

                    case 0:

                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 4.");
                        break;
                }
            }
        }

        static void GuestBooking(List<Room> rooms, List<Guest> guests)
        {
            //case 1
            Console.WriteLine("Total guests :" + guests.Count());
            var guestNoRoom = guests.Where(r=> r.roomNumber == "Not Assigned").ToList();
            Console.WriteLine("Total guests with no assigned room :" + guestNoRoom.Count());
            //case 2
            Console.WriteLine("Total rooms :" + rooms.Count());
            var booked = rooms.Where(r => r.isAvailable ==false).ToList();
            Console.WriteLine("Total rooms currently booked :" + booked.Count());
            //case 3
            var ActiveGuests = guests.Where(r => r.roomNumber != "Not Assigned").ToList();
            double avgPrice = ActiveGuests.Average(g => g.totalNights);
            Console.WriteLine("Average nights spent :" + avgPrice);
            //case 4
            var decOrder = guests.OrderByDescending(g=> g.calculateTotalCost(rooms)).Take(3).ToList();
            foreach(Guest r in decOrder)
            {
                r.displayGuest();
                Console.WriteLine("Total cost :" + r.calculateTotalCost(rooms));
            }
            //case 5
            var summery = guests.Select(g => $"Guest name :{g.guestName} Room number : {g.roomNumber} nights : {g.totalNights} TotalCost : {g.calculateTotalCost(rooms)}").ToList();
            foreach(string line in summery)
            {
                Console.WriteLine(line);
            }
        }
        static void UpdateRoomPrice(List<Room> rooms)
        {
            //ask user 
            try
            {
              
                Console.Write("Enter room number you want:");
                int roomNum = Convert.ToInt32(Console.ReadLine());
                //now we check 
               
                Room roomBook = rooms.FirstOrDefault(r => r.roomNumber == roomNum);
                if ((roomBook == null))
                {

                    Console.WriteLine("ERROR: invalid room number");

                }
                else
                {
                    //ask for new price
                    Console.Write("Enter room new room price:");
                    double price = Convert.ToDouble(Console.ReadLine());
                    if (price <= 0)
                    {
                        Console.WriteLine("ERROR: invalid room price");

                    }
                    else
                    {
                        //update price
                        Console.WriteLine("Old price : " + roomBook.pricePerNight);
                        roomBook.pricePerNight = price;
                        Console.WriteLine("New price : " + roomBook.pricePerNight);

                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: invalid input");
            }


        }
        static void GuestLookUp(List<Guest> guests)
        {
            try
            {
                //ask user
                Console.Write("Enter the name you  want to search:");
                string name = Console.ReadLine().ToLower();
                //now we search
                var matchingNames = guests.Where(r => r.guestName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList(); //will ignore the case
                if (matchingNames.Count > 0)
                {
                    foreach (Guest g in matchingNames)
                    {
                        g.displayGuest();
                    }

                }
                else
                {
                    Console.WriteLine("No guests matched that search");
                }



            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR: invalid input");
            }
        }
        static void RoomTypeBreakDown(List<Room> rooms)
        {
            //first we get the lis of all types seperatly
            var singleRooms = rooms.Where(r=> r.roomType =="single").ToList();
            var doubleRooms = rooms.Where(r => r.roomType == "double").ToList();
            var suiteRooms = rooms.Where(r => r.roomType == "suite").ToList();
            //display count for each
            Console.WriteLine("Amount of single Rooms: " + singleRooms.Count());
            Console.WriteLine("Amount of double Rooms: " + doubleRooms.Count());
            Console.WriteLine("Amount of suite Rooms: " + suiteRooms.Count());
            //display average
            if (singleRooms.Count > 0) { Console.WriteLine("Average price of single Rooms: " + singleRooms.Average(r=> r.pricePerNight)); }
            else { Console.WriteLine("Average price of single Rooms: N/A "); }

            if (doubleRooms.Count > 0) { Console.WriteLine("Average price of double Rooms: " + doubleRooms.Average(r=> r.pricePerNight)); }
            else { Console.WriteLine("Average price of double Rooms: N/A "); }

            if (suiteRooms.Count > 0) { Console.WriteLine("Average price of suite Rooms: " + suiteRooms.Average(r => r.pricePerNight)); }
            else { Console.WriteLine("Average price of suite Rooms: N/A "); }
            //average for all
            Console.WriteLine("Average price of All Rooms: " + rooms.Average(r => r.pricePerNight));



        }
        static void GuestCheckOut(List<Room> rooms, List<Guest> guests)
        {
            try
            {
                //ask user
                Console.Write("Enter guest ID:");
                string id = Console.ReadLine();
                //now we search
                var checkOutGuest = guests.FirstOrDefault(r => r.guestId == id);
                if (checkOutGuest == null)
                {
                    //guest not found
                    Console.WriteLine("No guests matched that search");


                }
                else
                {
                   //check if guest has active booking
                   if (checkOutGuest.roomNumber == "Not Assigned")
                    {
                        Console.WriteLine("This guest has no active booking");
                    }
                    else
                    {
                        //we get room
                        int roomNum = int.Parse(checkOutGuest.roomNumber);
                        var roomChecked = rooms.FirstOrDefault(r=> r.roomNumber == roomNum);
                        if (roomChecked != null)
                        {
                            //display bill 
                            checkOutGuest.displayGuest();
                            Console.WriteLine("Total Cost : "+ checkOutGuest.calculateTotalCost(rooms));
                            Console.WriteLine("Price per night : " + roomChecked.pricePerNight);
                            //then we ask clerk
                            Console.Write("confirm checkout (Y/N):");
                            string confirm = Console.ReadLine().ToLower();
                            if ((confirm == "y") || (confirm == "yes")) 
                            {
                                roomChecked.isAvailable = true;
                                //then we remove the guest
                                guests.Remove(checkOutGuest);
                                //display summery
                                Console.WriteLine("Checked out Room id : " + id + "Name of Checked out Guest:"+ checkOutGuest.guestName+" Room number: "+roomNum);
                                Console.WriteLine("Room count : " + rooms.Count());
                                Console.WriteLine("Guest count : " + guests.Count());
                                
                                Console.WriteLine("Room is available : " + rooms.Any(r => (r.roomNumber == roomNum) && (r.isAvailable == true)));





                            }
                            else if ((confirm == "n") || (confirm == "no"))
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine("ERROR: invalid input");
                            }


                        }

                    }
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: invalid input");
            }


        }
    }
}
