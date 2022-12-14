using System;

namespace Transport
{
    public class Train : GroundTransport
    {
        int freeSeats;

        public Train(string transportType, int flightNumber, string departure,
            string destination, double[] ticketPrice, int freeSeats): 
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
                    case "люкс":
                        result = ticketPrice[0];
                        break;
                    case "купейный":
                        result = ticketPrice[1];
                        break;
                    case "плацкартный":
                        result = ticketPrice[2];
                        break;
                    case "общий":
                        result = ticketPrice[3];
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
