using System;
using System.Collections.Generic;
using System.Text;

namespace Task_7
{
    public class Room
    {
        public int roomNumber { get; set; }
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
}
