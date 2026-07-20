using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    internal class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }
        public Room(int roomnumber, string roomType, double pricepernight)
        {
            RoomNumber = roomnumber;
            RoomType = roomType;
            PricePerNight = pricepernight;
            IsAvailable = true;
        }
        public void DisplayRoom()
        {
            Console.WriteLine("Room: " + RoomNumber);
            Console.WriteLine("Type: " + RoomType);
            Console.WriteLine("Price: " + PricePerNight);
            Console.WriteLine("Status: " + (IsAvailable ? "Available" : "Booked"));
        }
    }
}
