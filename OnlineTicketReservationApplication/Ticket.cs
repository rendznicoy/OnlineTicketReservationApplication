using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketReservationApplication
{
    public class Ticket
    {
        public string TicketType { get; private set; } //Round Trip, One-way, Multi-City
        public string TicketClass { get; private set; } //Economy Class, Comfort Class, Business Class
        public string FlightOrigin { get; private set; } //From
        public string FlightDestination { get; private set; } //To
        public DateTime DepartureDateTime { get; private set; }
        public DateTime ReturnDateTime { get; private set; } //Date of Return for a Round Trip Ticket
        public int TicketPrice { get; private set; }
        public int TicketQuantity { get; private set; }
        public bool isOneWay { get; private set; }
        public Ticket(string ticketType, string ticketClass, string flightOrigin, string flightDestination, int ticketPrice, int ticketQuantity)
        {
            this.TicketType = ticketType;
            this.TicketClass = ticketClass;
            this.FlightOrigin = flightOrigin;
            this.FlightDestination = flightDestination;
            this.DepartureDateTime = default(DateTime);
            this.ReturnDateTime = default(DateTime);
            this.TicketPrice = ticketPrice;
            this.TicketQuantity = ticketQuantity;
            this.isOneWay = false;
        }

        public override string ToString()
        {
            return this.TicketType + '\n' + this.TicketClass + '\n' + this.FlightOrigin + '\n' + this.FlightDestination + '\n' + this.TicketPrice + '\n' + this.TicketQuantity + '\n';
        }
    }
}
