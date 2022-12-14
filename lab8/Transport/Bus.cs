using System;

namespace Transport
{
    public class Bus : GroundTransport
    {
        int freeSeats;

        public Bus(string transportType, int flightNumber, string departure,
            string destination, double[] ticketPrice, int freeSeats) : 
            base(transportType, flightNumber, departure, destination, ticketPrice)
        {
            this.freeSeats = freeSeats;
        }

        public override double this[string index]
        {
            get
            {
                double result;

                switch (index)
                {
                    case "мягкий":
                        result = ticketPrice[0];
                        break;
                    case "жесткий":
                        result = ticketPrice[1];
                        break;
                    default:
                        throw new Exception("Unknown Index");
                }

                return result;
            }
        }

        public override int FreeSeats
        {
            get { return freeSeats; }
        }
    }
}
