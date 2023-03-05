using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketReservationApplication
{
    public class Seat
    {
        public int SeatNumber { get; private set; }
        public string SeatClass { get; private set; } //Economy Class, Comfort Class, Business Class
        public string SeatPosition { get; private set; } //Window, Aisle

        public Seat(int seatNumber, string seatClass, string seatPosition)
        {
            this.SeatNumber = seatNumber;
            this.SeatClass = seatClass;
            this.SeatPosition = seatPosition;
        }

        public override string ToString() 
        {
            return this.SeatNumber + '\n' + this.SeatClass + '\n' + this.SeatPosition + '\n';
        }
    }