namespace Transport
{
    public abstract class GroundTransport : ITransport
    {
        private protected string transportType;
        private protected int flightNumber;
        private protected string departure;
        private protected string destination;
        private protected double[] ticketPrice;

        public GroundTransport(string transportType, int flightNumber,  string departure, 
            string destination, double[] ticketPrice)
        {
            this.transportType = transportType;
            this.flightNumber = flightNumber;
            this.departure = departure;
            this.destination = destination;
            this.ticketPrice = ticketPrice;
        }

        public abstract double this[string index] { get; }

        public abstract int FreeSeats { get; }

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
