using System;

namespace FlatsLibrary
{
    public class FourRoomFlat : Flat
    {
        public FourRoomFlat(int amountOfRooms, double ceilingHeight, int amountOfWindows, bool furniture,
            int floor, bool washingMachine, string? stove, double squareMeterCost, double firstRoomArea,
            double secondRoomArea, double thirdRoomArea, double fourthRoomArea)
            : base(amountOfRooms, ceilingHeight, amountOfWindows, furniture, floor, washingMachine, stove, squareMeterCost)
        {
            this.firstRoomArea = firstRoomArea;
            this.secondRoomArea = secondRoomArea;
            this.thirdRoomArea = thirdRoomArea;
            this.fourthRoomArea = fourthRoomArea;
        }

        double firstRoomArea;
        double secondRoomArea;
        double thirdRoomArea;
        double fourthRoomArea;

        override public double GetRent()
        {
            double rent = (firstRoomArea + secondRoomArea + thirdRoomArea + fourthRoomArea) * squareMeterCost;
            return rent;
        }

        public override double GetSquare()
        {
            double square = firstRoomArea + secondRoomArea + thirdRoomArea + fourthRoomArea;
            return square;
        }
    }
}
