namespace Transport
{
    public interface ITransport
    {
        int FreeSeats { get; }

        string Departure { get; }

        string Destination { get; }

        string TransportType { get; }

        double this[string index] { get; }

        int FlightNumber { get; }

        string TicketPrice { get; }
    }
}
