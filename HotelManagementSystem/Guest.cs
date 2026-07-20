using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    internal class Guest
    {
        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public int RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }

        public Guest(string id, string name, string date, int nights)
        {
            GuestId = id;
            GuestName = name;
            CheckInDate = date;
            TotalNights = nights;
            RoomNumber = 0;
        }


        public double CalculateTotalCost(double pricePerNight)
        {
            return TotalNights * pricePerNight;
        }


        public void DisplayGuest()
        {
            Console.WriteLine($"ID: {GuestId}");
            Console.WriteLine($"Name: {GuestName}");
            Console.WriteLine($"Room: {(RoomNumber == 0 ? "Not Assigned" : RoomNumber.ToString())}");
            Console.WriteLine($"Date: {CheckInDate}");
            Console.WriteLine($"Nights: {TotalNights}");
        }
    }
}
