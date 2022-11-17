using System;

namespace FlatsLibrary
{
    public class Flat
    {
        public Flat(int amountOfRooms, double ceilingHeight, int amountOfWindows, bool furniture,
            int floor, bool washingMachine, string? stove, double squareMeterCost)
        {
            this.amountOfRooms = amountOfRooms;
            this.ceilingHeight = ceilingHeight;
            this.amountOfWindows = amountOfWindows;
            this.furniture = furniture;
            this.floor = floor;
            this.washingMachine = washingMachine;
            this.stove = stove;
            this.squareMeterCost = squareMeterCost;
        }

        public int amountOfRooms;
        public double ceilingHeight;
        public int amountOfWindows;
        public bool furniture;
        public int floor;
        public bool washingMachine;
        public string? stove;
        public double squareMeterCost;

        public virtual double GetRent()
        {
            double rent = squareMeterCost * amountOfRooms * 10;
            return rent;
        }

        public virtual double GetSquare()
        {
            double square = 10;
            return square;
        }
    }
}