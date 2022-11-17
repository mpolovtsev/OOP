using System.Text.RegularExpressions;

namespace TicketLibrary
{
    public enum Place
    {
        Parterre,
        Loggia,
        Balcony
    }

    public class Ticket
    {
        Place place;
        string date;

        public Ticket(Place place, string date)
        {
            this.place = place;
            this.date = date;
        }

        public static int AmountOfTickets(List<Ticket> tickets, string date)
        {
            int amountOfTickets = 0;

            foreach (var ticket in tickets)
            {
                if (String.Compare(ticket.date, date) == 0)
                {
                    amountOfTickets++;
                }
            }

            return amountOfTickets;
        }

        public static (double, double, double) AverageAmountOfTickets(List<Ticket> tickets, string start, string end)
        {
            var result = (0.0, 0.0, 0.0);
            string[] startDate = start.Split('.');
            string[] endDate = end.Split('.');

            int startDay = Convert.ToInt32(startDate[0]);
            int startMonth = Convert.ToInt32(startDate[1]);
            int amountOfStartDays = startDay + startMonth * 30;

            int endDay = Convert.ToInt32(endDate[0]);
            int endMonth = Convert.ToInt32(endDate[1]);
            int amountOfEndDays = endDay + endMonth * 30;

            if ((startDay <= endDay && startMonth == endMonth) || (startMonth < endMonth))
            {
                int parterre = 0;
                int loggia = 0;
                int balcony = 0;
                int day = 0;
                int month = 0;
                int amountOfCurrentDays = 0;
                string[] dateOfTicket;

                foreach (var ticket in tickets)
                {
                    dateOfTicket = ticket.date.Split('.');
                    day = Convert.ToInt32(dateOfTicket[0]);
                    month = Convert.ToInt32(dateOfTicket[1]);
                    amountOfCurrentDays = day + month * 30;

                    if (amountOfCurrentDays >= amountOfStartDays && amountOfCurrentDays <= amountOfEndDays)
                    {
                        switch (ticket.place)
                        {
                            case Place.Parterre:
                                parterre++;
                                break;
                            case Place.Loggia:
                                loggia++;
                                break;
                            case Place.Balcony:
                                balcony++;
                                break;
                        }
                    }
                }

                int period = amountOfEndDays - amountOfStartDays + 1;
                double averageParterre = Math.Round((double)parterre / period, 2);
                double averageLoggia = Math.Round((double)loggia / period, 2);
                double averageBalcony = Math.Round((double)balcony / period, 2);

                result = (averageParterre, averageLoggia, averageBalcony);
            }

            return result;
        }

        public static string MinAmountOfTickets(List<Ticket> tickets, string start, string end)
        {
            string result = "";
            string[] startDate = start.Split('.');
            string[] endDate = end.Split('.');

            int startDay = Convert.ToInt32(startDate[0]);
            int startMonth = Convert.ToInt32(startDate[1]);
            int amountOfStartDays = startDay + startMonth * 30;

            int endDay = Convert.ToInt32(endDate[0]);
            int endMonth = Convert.ToInt32(endDate[1]);
            int amountOfEndDays = endDay + endMonth * 30;

            if ((startDay <= endDay && startMonth == endMonth) || (startMonth < endMonth))
            {
                int period = amountOfEndDays - amountOfStartDays + 1;
                int[] amountOfTickets = new int[period];
                int day = 0;
                int month = 0;
                int amountOfCurrentDays = 0;
                string[] dateOfTicket;
                bool isChanged = false;
                int currentNumber = 0;

                foreach (var ticket in tickets)
                {
                    dateOfTicket = ticket.date.Split('.');
                    day = Convert.ToInt32(dateOfTicket[0]);
                    month = Convert.ToInt32(dateOfTicket[1]);
                    amountOfCurrentDays = day + month * 30;

                    if (amountOfCurrentDays >= amountOfStartDays && amountOfCurrentDays <= amountOfEndDays)
                    {
                        currentNumber = day - startDay + (month - startMonth) * 30;
                        amountOfTickets[currentNumber] += 1;
                        isChanged = true;
                    }
                }

                int minIndex = 0;

                if (isChanged)
                {
                    for (int i = 1; i < amountOfTickets.Length; i++)
                    {
                        if (amountOfTickets[i] < amountOfTickets[minIndex])
                        {
                            minIndex = i;
                        }
                    }


                    int amountOfDays = amountOfStartDays + minIndex;
                    int minDay = amountOfDays % 30;
                    int minMonth = amountOfDays / 30;
                    if (minDay < 10)
                    {
                        result = $"0{minDay}.{minMonth}.2022 ({amountOfTickets[minIndex]})";
                    }
                    else
                    {
                        result = $"{minDay}.{minMonth}.2022 ({amountOfTickets[minIndex]})";
                    }
                }
                else
                {
                    result = "За этот период не было продано ни одного билета.";
                }
            }

            return result;
        }
    }
}