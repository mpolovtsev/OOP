using System;

namespace FlatsLibrary
{
    public class OneRoomFlat : Flat
    {
        public OneRoomFlat(int amountOfRooms, double ceilingHeight, int amountOfWindows, bool furniture,
            int floor, bool washingMachine, string? stove, double squareMeterCost, double firstRoomArea)
            : base(amountOfRooms, ceilingHeight, amountOfWindows, furniture, floor, washingMachine, stove, squareMeterCost)
        {
            this.firstRoomArea = firstRoomArea;
        }

        double firstRoomArea;

        public override double GetRent()
        {
            double rent = firstRoomArea * squareMeterCost;
            return rent;
        }

        public override double GetSquare()
        {
            double square = firstRoomArea;
            return square;
        }
    }
}
