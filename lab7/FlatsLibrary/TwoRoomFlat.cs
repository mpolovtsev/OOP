using System;

namespace FlatsLibrary
{
    public class TwoRoomFlat : Flat
    {
        public TwoRoomFlat(int amountOfRooms, double ceilingHeight, int amountOfWindows, bool furniture,
            int floor, bool washingMachine, string? stove, double squareMeterCost, double firstRoomArea,
            double secondRoomArea)
            : base(amountOfRooms, ceilingHeight, amountOfWindows, furniture, floor, washingMachine, stove, squareMeterCost)
        {
            this.firstRoomArea = firstRoomArea;
            this.secondRoomArea = secondRoomArea;
        }

        double firstRoomArea;
        double secondRoomArea;

        override public double GetRent()
        {
            double rent = (firstRoomArea + secondRoomArea) * squareMeterCost;
            return rent;
        }

        public override double GetSquare()
        {
            double square = firstRoomArea + secondRoomArea;
            return square;
        }
    }
}
