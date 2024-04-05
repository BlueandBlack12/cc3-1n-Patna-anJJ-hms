using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Hotel
    {
        public string HotelName { get; set; }
        public string Location { get; set; }
        private List<HotelRoom> _allRooms { get; set; }

        public Hotel(string hotelName, string location)
        {
            HotelName = hotelName;
            Location = location;
            _allRooms = new List<HotelRoom>();
        }

        public void AddRoom(int roomNumber, RoomStyle style, decimal bookingPrice)
        {
            _allRooms.Add(new HotelRoom(roomNumber, style, bookingPrice));
        }

        public void DisplayAvailableRooms()
        {
            Console.WriteLine($"Available rooms at {HotelName}, {Location}:");
            foreach (var room in _allRooms)
            {
                if (room.IsAvailable)
                {
                    Console.WriteLine($"Room Number: {room.RoomNumber}, Style: {room.Style}, Booking Price: {room.BookingPrice}");
                }
            }
        }
    }


}
