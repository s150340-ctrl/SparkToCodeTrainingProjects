using System;
using System.Collections.Generic;
using System.Text;

namespace Task_7
{
    public class Guest
    {
        public string guestId { get; set; }
        public string guestName { get; set; }
        public string roomNumber { set; get; } = "Not Assigned";
        public DateTime checkInDate { set; get; }
        public int totalNights { set; get; }
        //constructer
        public Guest() { }
        public Guest(string id, string name, string room, DateTime date, int nights)
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
            if (roomNumber == "Not Assigned") { return 0; }
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
}
