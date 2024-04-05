using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Receptionist : User
    {
        public Receptionist(string name, string address, string email, long phoneNumber) : base(name, address, email, phoneNumber)
        {
        }

        public void BookRoom(Guest guest, HotelRoom room, DateTime startTime, DateTime endTime)
        {
            guest.BookRoom(room, startTime, endTime);
        }
    }
}
