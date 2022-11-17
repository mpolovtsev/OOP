using TicketLibrary;
using System.Text.RegularExpressions;

namespace Window
{
    public partial class Form1 : Form
    {
        public List<Ticket> tickets = new List<Ticket>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Place place = Place.Parterre;

            if (parter.Checked)
            {
                place = Place.Parterre;   
            }
            else if (loggia.Checked)
            {
                place = Place.Loggia;
            }
            else if (balcony.Checked)
            {
                place = Place.Balcony;
            }

            Ticket ticket;
            Regex re = new Regex(@"\d{2}\.\d{2}.2022");
            string date = this.date.Text;

            if (date == "")
            {
                MessageBox.Show("���� \"����\" �����. ������� ��������.");
            }
            else if (re.IsMatch(date))
            {
                ticket = new Ticket(place, date);
                tickets.Add(ticket);
            }
            else
            {
                MessageBox.Show("������� ���� � ������� ��.��.2022");
            }
        }

        private void method1_Click(object sender, EventArgs e)
        {
            Regex re = new Regex(@"\d{2}\.\d{2}.2022");

            if (tickets.Count == 0)
            {
                MessageBox.Show("���� �� ������ ������.");
            }
            else if (date1.Text == "")
            {
                MessageBox.Show("���� \"����\" �����. ������� ��������.");
            }
            else if (re.IsMatch(date1.Text))
            {
                result1.Text = (Ticket.AmountOfTickets(tickets, date1.Text)).ToString();
            }
            else
            {
                MessageBox.Show("������� ���� � ������� ��.��.2022");
            }
        }

        private void method2_Click(object sender, EventArgs e)
        {
            (double, double, double) result;
            Regex re = new Regex(@"\d{2}\.\d{2}.2022");

            if (tickets.Count == 0)
            {
                MessageBox.Show("���� �� ������ ������.");
            }
            else if (start1.Text == "" || end1.Text == "")
            {
                MessageBox.Show("���� \"������\" � \"�����\" �����. ������� ��������.");
            }
            else if (re.IsMatch(start1.Text) && re.IsMatch(end1.Text))
            {
                result = Ticket.AverageAmountOfTickets(tickets, start1.Text, end1.Text);
                result2.Text = $"������ - {result.Item1}, ������ - {result.Item2}, ������ - {result.Item3}";
            }
            else
            {
                MessageBox.Show("������� ���� � ������� ��.��.2022");
            }
        }

        private void method3_Click(object sender, EventArgs e)
        {
            Regex re = new Regex(@"\d{2}\.\d{2}.2022");

            if (tickets.Count == 0)
            {
                MessageBox.Show("���� �� ������ ������.");
            }
            else if (start2.Text == "" || end2.Text == "")
            {
                MessageBox.Show("���� \"������\" � \"�����\" �����. ������� ��������.");
            }
            else if (re.IsMatch(start2.Text) && re.IsMatch(end2.Text))
            {
                result3.Text = Ticket.MinAmountOfTickets(tickets, start2.Text, end2.Text);
            }
            else
            {
                MessageBox.Show("������� ���� � ������� ��.��.2022");
            }
        }
    }
}