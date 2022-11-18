using System;

namespace FlatsLibrary
{
    public class ThreeRoomFlat : Flat
    {
        public ThreeRoomFlat(int amountOfRooms, double ceilingHeight, int amountOfWindows, bool furniture,
            int floor, bool washingMachine, string? stove, double squareMeterCost, double firstRoomArea,
            double secondRoomArea, double thirdRoomArea)
            : base(amountOfRooms, ceilingHeight, amountOfWindows, furniture, floor, washingMachine, stove, squareMeterCost)
        {
            this.firstRoomArea = firstRoomArea;
            this.secondRoomArea = secondRoomArea;
            this.thirdRoomArea = thirdRoomArea;
        }

        double firstRoomArea;
        double secondRoomArea;
        double thirdRoomArea;

        public override double GetRent()
        {
            double rent = (firstRoomArea + secondRoomArea + thirdRoomArea) * squareMeterCost;
            return rent;
        }

        public override double GetSquare()
        {
            double square = firstRoomArea + secondRoomArea + thirdRoomArea;
            return square;
        }
    }
}
