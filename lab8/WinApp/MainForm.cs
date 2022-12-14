using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Transport;
using FileLibrary;

namespace WinApp
{
    public partial class MainForm : Form
    {
        const string fileName = "TransportInfo.txt";
        public List<ITransport> transport;

        public MainForm()
        {
            InitializeComponent();

            transport = FileWork.ReadFile(fileName);
            CreateTable();
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(fileName, true);
            string line = $"\n{TransportTypeTb.Text} {FlightNumberTb.Text} {DepartureTb.Text} " +
                $"{DestinationTb.Text} {TicketPriceTb.Text} {FreeSeatsTb.Text}";

            writer.Write(line);

            writer.Close();

            transport.Clear();
            transport = FileWork.ReadFile(fileName);

            CreateTable();
        }

        void CreateTable()
        {
            TransportTable.Items.Clear();

            TransportTable.View = View.Details;
            TransportTable.GridLines = true;
            TransportTable.FullRowSelect = true;

            ListViewItem item;

            foreach (ITransport element in transport)
            {
                string[] row = new string[6];

                row[0] = element.TransportType;
                row[1] = element.FlightNumber.ToString();
                row[2] = element.Departure;
                row[3] = element.Destination;
                row[4] = element.TicketPrice;
                row[5] = element.FreeSeats.ToString();

                item = new ListViewItem(row);

                if (element.FreeSeats == 0)
                {
                    item.BackColor = Color.FromArgb(255, 0, 0);
                }

                TransportTable.Items.Add(item);
            }
        }

        private void FindCostBttn_Click(object sender, EventArgs e)
        {
            ResultTb.Text = (transport[int.Parse(IndexTb.Text) - 1][CategoryTb.Text]).ToString();
        }
    }
}
