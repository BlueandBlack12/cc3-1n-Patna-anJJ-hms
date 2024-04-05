﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelManagementSystem
{
    public class Guest : User
    {

        public List<Reservation> Reservations { get; set; }

        public Guest(string name, string address, string email, long phoneNumber) : base(name, address, email, phoneNumber)
        {
            Reservations = new List<Reservation>();
        }

        public void BookRoom(HotelRoom room, DateTime startTime, DateTime endTime)
        {
            
            if (!room.Status)
            {
                Console.WriteLine("\t Room is not available for booking.");
                return;
            }

            
            int reservationNumber = GenerateReservationNumber();
            Reservation reservation = new Reservation(reservationNumber, startTime, endTime, room);
            Reservations.Add(reservation);

            
            room.Status = false;

            Console.WriteLine($"\t Room {room.RoomNumber} booked successfully.");
        }

        private int GenerateReservationNumber()
        {
            
            return 0; 
        }

        public void DisplayReservations()
        {
            Console.WriteLine($"\t Reservations of {Name}:");
            foreach (var reservation in Reservations)
            {
                Console.WriteLine($"Reservation Number: {reservation.ReservationNumber}, Room Number: {reservation.Room.RoomNumber}, Start Time: {reservation.StartTime}, End Time: {reservation.EndTime}, Duration: {reservation.DurationInDays} days");
            }
        }
    }
}
