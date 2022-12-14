using System;
using System.Runtime.InteropServices;

namespace Transport
{
    public class Airplane : ITransport
    {
        string transportType;
        int flightNumber;
        string departure;
        string destination;
        double[] ticketPrice;
        int freeSeats;

        public Airplane(string transportType, int flightNumber, string departure,
            string destination, double[] ticketPrice, int freeSeats)
        {
            this.transportType = transportType;
            this.flightNumber = flightNumber;
            this.departure = departure;
            this.destination = destination;
            this.ticketPrice = ticketPrice;
            this.freeSeats = freeSeats;
        }

        public double this[string index]
        {
            get
            {
                double result;

                switch(index)
                {
                    case "эконом":
                        result = ticketPrice[0];
                        break;
                    case "бизнес":
                        result = ticketPrice[1];
                        break;
                    case "первый":
                        result = ticketPrice[2];
                        break;
                    default:
                        throw new Exception("Unknown Index");
                }
                
                return result;
            }
        }

        public int FreeSeats
        {
            get { return freeSeats; }
        }

        public string Departure
        {
            get { return departure; }
        }

        public string Destination
        {
            get { return destination; }
        }

        public string TransportType
        {
            get { return transportType; }
        }

        public int FlightNumber
        {
            get { return flightNumber; }
        }

        public string TicketPrice
        {
            get
            {
                string result = "";

                for (int i = 0; i < ticketPrice.Length; i++)
                {
                    result += $"{ticketPrice[i]} ";
                }

                return result;
            }
        }
    }
}
