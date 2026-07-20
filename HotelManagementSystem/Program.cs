namespace HotelManagementSystem
{
    internal class Program
    {
        

       
        static List<Room> rooms = new List<Room>();
        static List<Guest> guests = new List<Guest>();
        static void LoadRooms()
        {
            rooms.Add(new Room(101, "Single", 20));
            rooms.Add(new Room(102, "Single", 25));
            rooms.Add(new Room(201, "Double", 40));
            rooms.Add(new Room(202, "Double", 45));
            rooms.Add(new Room(301, "Suite", 80));
            rooms.Add(new Room(302, "Suite", 100));
        }
        static void Main(string[] args)
        {
            LoadRooms();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("GRAND VISTA HOTEL");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book Room");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guests");
                Console.WriteLine("6. Search & Filter Rooms");
                Console.WriteLine("7. Guest & Booking Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup by Name");
               Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("0. Exit");


                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddRoom();
                        break;

                    case 2:
                        RegisterGuest();
                        break;
                    case 3:
                        BookRoom();
                        break;

                    case 4:
                        ViewAllRooms();
                        break;

                    case 5:
                        ViewAllGuests();
                        break;
                    case 6:
                        SearchFilterRooms();
                        break;
                    case 7:
                        GuestBookingStatistics();
                        break;
                    case 8:
                        UpdateRoomPrice();
                        break;

                    case 9:
                        GuestLookupByName();
                        break;

                    case 10:
                        RoomTypeBreakdownReport();
                        break;

                    case 11:
                        CheckOutGuest();
                        break;

                    case 12:
                        RemoveUnavailableRooms();
                        break;

                    case 13:
                        ExtendGuestStay();
                        break;

                    case 14:
                        HighestRevenueBooking();
                        break;

                    case 15:
                        GuestPaginationViewer();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
        }
        static void AddRoom()
        {
            Console.Write("Enter room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            if (roomNumber <= 0)
            {
                Console.WriteLine("Invalid room number.");
                return;
            }

            if (rooms.Any(r => r.RoomNumber == roomNumber))
            {
                Console.WriteLine("Room already exists.");
                return;
            }

            Console.Write("Enter room type (Single/Double/Suite): ");
            string roomType = Console.ReadLine();

            Console.Write("Enter price per night: ");
            double price = double.Parse(Console.ReadLine());

            if (price <= 0)
            {
                Console.WriteLine("Invalid price.");
                return;
            }

            Room room = new Room(roomNumber, roomType, price);

            rooms.Add(room);

            Console.WriteLine("Room added successfully.");
            Console.WriteLine("Total rooms: " + rooms.Count);
        }

        static void RegisterGuest()
        {
            Console.Write("Enter guest name: ");
            string name = Console.ReadLine();

            Console.Write("Enter check-in date: ");
            string date = Console.ReadLine();

            Console.Write("Enter total nights: ");
            int nights = int.Parse(Console.ReadLine());

            if (nights <= 0)
            {
                Console.WriteLine("Invalid number of nights.");
                return;
            }

            string id = "G" + (guests.Count + 1).ToString("000");

            Guest guest = new Guest(id, name, date, nights);

            guests.Add(guest);

            Console.WriteLine("Guest registered successfully.");
            Console.WriteLine("Guest ID: " + id);
        }

        static void BookRoom()
        {
            Console.Write("Enter Guest ID: ");
            string guestId = Console.ReadLine();

            Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId);

            if (guest == null)
            {
                Console.WriteLine("Guest not found.");
                return;
            }

            Console.Write("Enter Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

            if (room == null)
            {
                Console.WriteLine("Room not found.");
                return;
            }

            if (!room.IsAvailable)
            {
                Console.WriteLine("Room is already booked.");
                return;
            }

            guest.RoomNumber = room.RoomNumber;
            room.IsAvailable = false;

            Console.WriteLine("Booking completed successfully.");
            Console.WriteLine("Guest: " + guest.GuestName);
            Console.WriteLine("Room: " + room.RoomNumber);
            Console.WriteLine("Total Cost: " + guest.CalculateTotalCost(room.PricePerNight));
        }
        static void ViewAllRooms()
        {
            if (rooms.Count == 0)
            {
                Console.WriteLine("No rooms have been added yet.");
                return;
            }

            Console.WriteLine("Total Rooms: " + rooms.Count);

            foreach (Room room in rooms.OrderBy(r => r.RoomNumber))
            {
                room.DisplayRoom();
               
            }
        }
        static void ViewAllGuests()
        {
            if (guests.Count == 0)
            {
                Console.WriteLine("No guests have been registered yet.");
                return;
            }

            Console.WriteLine("Total Guests: " + guests.Count);

            foreach (Guest guest in guests.OrderBy(g => g.GuestName))
            {
                guest.DisplayGuest();
                
            }
        }
        static void SearchFilterRooms()
        {
            Console.WriteLine("1. Show Available Rooms");
            Console.WriteLine("2. Filter By Room Type");
            Console.WriteLine("3. Filter By Maximum Price");
            Console.WriteLine("4. Room Price Statistics");
            Console.WriteLine("0. Back");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    var availableRooms = rooms
                        .Where(r => r.IsAvailable)
                        .OrderBy(r => r.PricePerNight);

                    Console.WriteLine("Available Rooms: " + availableRooms.Count());

                    foreach (var room in availableRooms)
                    {
                        room.DisplayRoom();
                       
                    }

                    break;

                case 2:

                    Console.Write("Enter Room Type: ");
                    string type = Console.ReadLine();

                    var roomType = rooms
                        .Where(r => r.RoomType.Equals(type, StringComparison.OrdinalIgnoreCase));

                    if (!roomType.Any())
                    {
                        Console.WriteLine("No rooms found.");
                        return;
                    }

                    foreach (var room in roomType)
                    {
                        room.DisplayRoom();
                        
                    }

                    break;

                case 3:

                    Console.Write("Enter Maximum Price: ");
                    double maxPrice = double.Parse(Console.ReadLine());

                    var priceRooms = rooms
                        .Where(r => r.IsAvailable && r.PricePerNight <= maxPrice)
                        .OrderBy(r => r.PricePerNight);

                    if (!priceRooms.Any())
                    {
                        Console.WriteLine("No rooms found.");
                        return;
                    }

                    foreach (var room in priceRooms)
                    {
                        room.DisplayRoom();
                       
                    }

                    break;

                case 4:

                    Console.WriteLine("Total Rooms: " + rooms.Count());
                    Console.WriteLine("Available Rooms: " + rooms.Count(r => r.IsAvailable));
                    Console.WriteLine("Average Price: " + rooms.Average(r => r.PricePerNight).ToString("F2"));
                    Console.WriteLine("Lowest Price: " + rooms.Min(r => r.PricePerNight).ToString("F2"));
                    Console.WriteLine("Highest Price: " + rooms.Max(r => r.PricePerNight).ToString("F2"));

                    break;
            }
        }
        static void GuestBookingStatistics()
        {
            Console.WriteLine("Total Guests: " + guests.Count);

            Console.WriteLine("Guests With Booking: " +
                guests.Count(g => g.RoomNumber != 0));

            Console.WriteLine("Total Rooms: " + rooms.Count);

            Console.WriteLine("Booked Rooms: " +
                rooms.Count(r => !r.IsAvailable));

            var bookedGuests = guests.Where(g => g.RoomNumber != 0);

            if (!bookedGuests.Any())
            {
                Console.WriteLine("No active bookings recorded.");
                return;
            }

            Console.WriteLine("Average Nights: " +
                bookedGuests.Average(g => g.TotalNights));

            Console.WriteLine("Top Guests:");

            var topGuests = bookedGuests.OrderByDescending(g =>
            {
                Room room = rooms.FirstOrDefault(r => r.RoomNumber == g.RoomNumber);
                return g.CalculateTotalCost(room.PricePerNight);
            });

            foreach (var guest in topGuests.Take(3))
            {
                Room room = rooms.FirstOrDefault(r => r.RoomNumber == guest.RoomNumber);

                Console.WriteLine(guest.GuestName);
                Console.WriteLine("Room: " + guest.RoomNumber);
                Console.WriteLine("Total Cost: " + guest.CalculateTotalCost(room.PricePerNight));
            }
        }
        static void UpdateRoomPrice()
        {

            Console.Write("Enter Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

            if (room == null)
            {
                Console.WriteLine("Room not found.");
                return;
            }

            double oldPrice = room.PricePerNight;

            Console.Write("Enter New Price: ");
            double newPrice = double.Parse(Console.ReadLine());

            if (newPrice <= 0)
            {
                Console.WriteLine("Invalid price.");
                return;
            }

            room.PricePerNight = newPrice;

            Console.WriteLine("Room price updated successfully.");
            Console.WriteLine("Old Price: " + oldPrice);
            Console.WriteLine("New Price: " + room.PricePerNight);
        }

        static void GuestLookupByName()
        {
            Console.Write("Enter guest name: ");
            string name = Console.ReadLine();

            var result = guests.Where(g =>
                g.GuestName.Contains(name, StringComparison.OrdinalIgnoreCase));

            if (!result.Any())
            {
                Console.WriteLine("No guests matched that search.");
                return;
            }

            Console.WriteLine("Guests Found: " + result.Count());

            foreach (Guest guest in result)
            {
                Console.WriteLine("ID: " + guest.GuestId);
                Console.WriteLine("Name: " + guest.GuestName);
                Console.WriteLine("Room: " +
                    (guest.RoomNumber == 0 ? "Not Assigned" : guest.RoomNumber));
            }
        }

        static void RoomTypeBreakdownReport()
        {

            string[] roomTypes = { "Single", "Double", "Suite" };

            foreach (string type in roomTypes)
            {
                int count = rooms.Count(r => r.RoomType == type);

                Console.WriteLine(type + " Rooms: " + count);

                if (count > 0)
                {
                    double average = rooms
                        .Where(r => r.RoomType == type)
                        .Average(r => r.PricePerNight);

                    Console.WriteLine("Average Price: " + average.ToString("F2"));
                }
                else
                {
                    Console.WriteLine("Average Price: N/A");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Overall Average Price: " +
                rooms.Average(r => r.PricePerNight).ToString("F2"));
        }

        static void CheckOutGuest()
        {
            Console.Write("Enter Guest ID: ");
            string id = Console.ReadLine();

            Guest guest = guests.FirstOrDefault(g => g.GuestId == id);

            if (guest == null)
            {
                Console.WriteLine("Guest not found.");
                return;
            }

            if (guest.RoomNumber == 0)
            {
                Console.WriteLine("This guest has no active booking.");
                return;
            }

            Room room = rooms.FirstOrDefault(r => r.RoomNumber == guest.RoomNumber);

            Console.WriteLine("Guest: " + guest.GuestName);
            Console.WriteLine("Room: " + room.RoomNumber);
            Console.WriteLine("Check In: " + guest.CheckInDate);
            Console.WriteLine("Nights: " + guest.TotalNights);
            Console.WriteLine("Price: " + room.PricePerNight);
            Console.WriteLine("Total: " + guest.CalculateTotalCost(room.PricePerNight));

            Console.Write("Confirm checkout (Y/N): ");
            string answer = Console.ReadLine();

            if (answer.ToUpper() == "Y")
            {
                room.IsAvailable = true;
                guests.Remove(guest);

                Console.WriteLine("Checkout completed.");
                Console.WriteLine("Total Rooms: " + rooms.Count);
                Console.WriteLine("Total Guests: " + guests.Count);
            }
        }

        static void RemoveUnavailableRooms()
        {
            var removeRooms = rooms
                    .Where(r => !r.IsAvailable &&
                    !guests.Any(g => g.RoomNumber == r.RoomNumber))
                    .OrderBy(r => r.RoomNumber);

            if (!removeRooms.Any())
            {
                Console.WriteLine("No rooms can be removed.");
                return;
            }

            foreach (Room room in removeRooms)
            {
                Console.WriteLine(room.RoomNumber + " " + room.RoomType);
            }

            Console.Write("Remove these rooms? (Y/N): ");
            string answer = Console.ReadLine();

            if (answer.ToUpper() == "Y")
            {
                rooms.RemoveAll(r =>
                    !r.IsAvailable &&
                    !guests.Any(g => g.RoomNumber == r.RoomNumber));

                Console.WriteLine("Remaining Rooms: " + rooms.Count);

                foreach (var room in rooms.Select(r => new { r.RoomNumber, r.RoomType }))
                {
                    Console.WriteLine(room.RoomNumber + " " + room.RoomType);
                }
            }
        }

        static void ExtendGuestStay()
        {
            Console.Write("Enter Guest ID: ");
            string id = Console.ReadLine();

            Guest guest = guests.FirstOrDefault(g => g.GuestId == id);

            if (guest == null)
            {
                Console.WriteLine("Guest not found.");
                return;
            }

            if (guest.RoomNumber == 0)
            {
                Console.WriteLine("This guest has no active booking.");
                return;
            }

            Console.Write("Additional Nights: ");
            int nights = int.Parse(Console.ReadLine());

            if (nights <= 0)
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            guest.TotalNights += nights;

            Room room = rooms.FirstOrDefault(r => r.RoomNumber == guest.RoomNumber);

            Console.WriteLine("Updated Nights: " + guest.TotalNights);
            Console.WriteLine("New Total Cost: " +
                guest.CalculateTotalCost(room.PricePerNight));
        }

        static void HighestRevenueBooking()
        {
            var booking = guests
                    .Where(g => g.RoomNumber != 0)
                    .Select(g => new
                    {
                        Guest = g,
                        Room = rooms.FirstOrDefault(r => r.RoomNumber == g.RoomNumber),
                        Total = g.CalculateTotalCost(
                            rooms.FirstOrDefault(r => r.RoomNumber == g.RoomNumber).PricePerNight)
                    })
                    .OrderByDescending(x => x.Total)
                    .Take(1);

            if (!booking.Any())
            {
                Console.WriteLine("No active bookings recorded.");
                return;
            }

            foreach (var item in booking)
            {
                Console.WriteLine("Guest: " + item.Guest.GuestName);
                Console.WriteLine("Room: " + item.Guest.RoomNumber);
                Console.WriteLine("Total: " + item.Total);
            }
        }

        static void GuestPaginationViewer()
        {
            int pageSize = 3;

            Console.Write("Enter Page Number: ");
            int page = int.Parse(Console.ReadLine());

            int totalPages = (int)Math.Ceiling((double)guests.Count / pageSize);

            if (page < 1 || page > totalPages)
            {
                Console.WriteLine("That page does not exist.");
                return;
            }

            var result = guests
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            Console.WriteLine("Page " + page + " of " + totalPages);

            foreach (Guest guest in result)
            {
                guest.DisplayGuest();
            }
        }
    }
}








