using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketReservationApplication
{
    public class Passenger
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public DateTime BirthDate { get; private set; }
        public int ContactNumber { get; private set; }
        public double LoyaltyPoints { get; private set; }

        public Passenger(string name, string email, string address, DateTime birthDate, int contactNumber)
        {
            this.Name = name;
            this.Email = email;
            this.Address = address;
            this.BirthDate = birthDate;
            this.ContactNumber = contactNumber;
            this.LoyaltyPoints = 0;
        }

        public override string toString()
        {
            return this.Name + '\n' + this.Email + '\n' + this.Address + '\n' + this.BirthDate + '\n' + this.ContactNumber + '\n';
        }
    }