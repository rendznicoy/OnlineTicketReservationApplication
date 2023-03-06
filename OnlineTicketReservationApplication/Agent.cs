using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketReservationApplication
{
    public class Agent
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int ContactNumber { get; private set; }
        public Agent(string name, string email, int contactNumber)
        {
            this.Name = name;
            this.Email = email;
            this.ContactNumber = contactNumber;
        }

        public bool AddTicket(Ticket ticket)
        {
            if (this.Ticket.Count != Ticket.MaxTicketCapacity())
            {
                Ticket.Add(ticket);
                return true;
            }
        }

        public override string ToString()
        {
            return this.Name + '\n' + this.Email + '\n' + this.ContactNumber + '\n';

        }
    }
}
