﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketReservationApplication
{
    public class Airplane
    {
        public List<Ticket> Ticket { get; private set; }
        public List<Seat> Seat { get; private set; }
        public List<Passenger> Passenger { get; private set; }
        public string AirplaneCompany { get; private set; }
        public string AirplaneCode { get; private set; } //Airplane Identification
        public string AirplaneModel { get; private set; }
        private int MaxTicketCapacity;
        private int MaxSeatCapacity;
        private int MaxPassengerCapacity;

        public Airplane(string airplaneCompany, string  airplaneCode, string airplaneModel, int maxTicketCapacity, int maxSeatCapacity, int maxPassengerCapacity)
        {
            this.Ticket = new List<Ticket>();
            this.Seat = new List<Seat>();
            this.Passenger = new List<Passenger>();
            this.AirplaneCompany = airplaneCompany;
            this.AirplaneCode = airplaneCode;
            this.AirplaneModel = airplaneModel;
            this.MaxTicketCapacity = maxTicketCapacity;
            this.MaxSeatCapacity = maxSeatCapacity;
            this.MaxPassengerCapacity = maxPassengerCapacity;
        }



        public override string ToString()
        {
            return this.AirplaneCompany + '\n' + this.AirplaneCode + '\n' + this.AirplaneModel + '\n';
        }
    }