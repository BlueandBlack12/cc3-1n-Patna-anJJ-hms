﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class HotelManagementSystem
    {
        private List<Hotel> hotels;
        private  List<User> users;
        private List<Reservation> reservations;

        public HotelManagementSystem()
        {
            hotels = new List<Hotel>();
        }

        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }

        public void DisplayHotels()
        {
            foreach (var hotel in hotels)
            {
                Console.WriteLine($"Hotel: {hotel.HotelName}, Location: {hotel.Location}");
            }
        }

        public void BookReservation(Hotel hotel, HotelRoom room, Guest guest, DateTime startTime, DateTime endTime)
        {
           
        }

        public void RegisterUser(User user)
        {
            
        }

        public void RegisterUser(Receptionist receptionist)
        {
            
        }

        public void DisplayReservationDetails(int reservationNumber)
        {
           
        }
    }
}
