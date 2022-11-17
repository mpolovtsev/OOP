using TicketLibrary;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Ticket ticket1 = new Ticket(Place.Parterre, "26.10.2022");
            Ticket ticket2 = new Ticket(Place.Parterre, "19.11.2022");
            Ticket ticket3 = new Ticket(Place.Balcony, "19.11.2022");
            Ticket ticket4 = new Ticket(Place.Loggia, "15.10.2022");
            Ticket ticket5 = new Ticket(Place.Balcony, "04.11.2022");

            List<Ticket> tickets = new List<Ticket>();
            tickets.Add(ticket1);
            tickets.Add(ticket2);
            tickets.Add(ticket3);
            tickets.Add(ticket4);
            tickets.Add(ticket5);

            int expected = 2;
            int result = Ticket.AmountOfTickets(tickets, "19.11.2022");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test2()
        {
            Ticket ticket1 = new Ticket(Place.Parterre, "26.10.2022");
            Ticket ticket2 = new Ticket(Place.Parterre, "19.11.2022");
            Ticket ticket3 = new Ticket(Place.Balcony, "19.11.2022");
            Ticket ticket4 = new Ticket(Place.Loggia, "15.10.2022");
            Ticket ticket5 = new Ticket(Place.Balcony, "04.11.2022");

            List<Ticket> tickets = new List<Ticket>();
            tickets.Add(ticket1);
            tickets.Add(ticket2);
            tickets.Add(ticket3);
            tickets.Add(ticket4);
            tickets.Add(ticket5);

            int expected = 0;
            int result = Ticket.AmountOfTickets(tickets, "30.10.2022");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test3()
        {
            Ticket ticket1 = new Ticket(Place.Parterre, "19.10.2022");
            Ticket ticket2 = new Ticket(Place.Parterre, "21.10.2022");
            Ticket ticket3 = new Ticket(Place.Balcony, "19.10.2022");
            Ticket ticket4 = new Ticket(Place.Loggia, "20.10.2022");
            Ticket ticket5 = new Ticket(Place.Balcony, "22.10.2022");

            List<Ticket> tickets = new List<Ticket>();
            tickets.Add(ticket1);
            tickets.Add(ticket2);
            tickets.Add(ticket3);
            tickets.Add(ticket4);
            tickets.Add(ticket5);

            (double, double, double) expected = (0.5, 0.25, 0.5);
            (double, double, double) result = Ticket.AverageAmountOfTickets(tickets, "19.10.2022", "22.10.2022");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test4()
        {
            Ticket ticket1 = new Ticket(Place.Parterre, "19.10.2022");
            Ticket ticket2 = new Ticket(Place.Parterre, "21.10.2022");
            Ticket ticket3 = new Ticket(Place.Balcony, "19.10.2022");
            Ticket ticket4 = new Ticket(Place.Loggia, "20.10.2022");
            Ticket ticket5 = new Ticket(Place.Balcony, "22.10.2022");

            List<Ticket> tickets = new List<Ticket>();
            tickets.Add(ticket1);
            tickets.Add(ticket2);
            tickets.Add(ticket3);
            tickets.Add(ticket4);
            tickets.Add(ticket5);

            (double, double, double) expected = (0.0, 0.0, 0.0);
            (double, double, double) result = Ticket.AverageAmountOfTickets(tickets, "23.10.2022", "25.10.2022");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test5()
        {
            Ticket ticket1 = new Ticket(Place.Parterre, "26.10.2022");
            Ticket ticket2 = new Ticket(Place.Parterre, "19.11.2022");
            Ticket ticket3 = new Ticket(Place.Parterre, "19.11.2022");
            Ticket ticket4 = new Ticket(Place.Parterre, "15.10.2022");
            Ticket ticket5 = new Ticket(Place.Parterre, "04.11.2022");

            List<Ticket> tickets = new List<Ticket>();
            tickets.Add(ticket1);
            tickets.Add(ticket2);
            tickets.Add(ticket3);
            tickets.Add(ticket4);
            tickets.Add(ticket5);

            string expected = "27.10.2022 (0)";
            string result = Ticket.MinAmountOfTickets(tickets, "26.10.2022", "26.11.2022");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test6()
        {
            Ticket ticket1 = new Ticket(Place.Parterre, "23.10.2022");
            Ticket ticket2 = new Ticket(Place.Parterre, "24.10.2022");
            Ticket ticket3 = new Ticket(Place.Parterre, "25.10.2022");
            Ticket ticket4 = new Ticket(Place.Parterre, "23.10.2022");
            Ticket ticket5 = new Ticket(Place.Parterre, "24.10.2022");

            List<Ticket> tickets = new List<Ticket>();
            tickets.Add(ticket1);
            tickets.Add(ticket2);
            tickets.Add(ticket3);
            tickets.Add(ticket4);
            tickets.Add(ticket5);

            string expected = "25.10.2022 (1)";
            string result = Ticket.MinAmountOfTickets(tickets, "23.10.2022", "25.10.2022");
            Assert.AreEqual(expected, result);
        }
    }
}