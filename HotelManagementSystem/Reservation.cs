﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Reservation
    {
        public int ReservationNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int DurationInDays => (EndTime - StartTime).Days;
        public HotelRoom Room { get; set; }
        public decimal Total {  get; set; }


        public Reservation(int reservationNumber, DateTime startTime, DateTime endTime, HotelRoom room)
        {
            ReservationNumber = reservationNumber;
            StartTime = startTime;
            EndTime = endTime;
            Room = room;
            Total = 0;
        }
    }
}
