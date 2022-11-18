using System;

namespace FlatsLibrary
{
    public class FiveRoomFlat : Flat
    {
        public FiveRoomFlat(int amountOfRooms, double ceilingHeight, int amountOfWindows, bool furniture,
            int floor, bool washingMachine, string? stove, double squareMeterCost, double firstRoomArea,
            double secondRoomArea, double thirdRoomArea, double fourRoomArea, double fiveRoomArea)
            : base(amountOfRooms, ceilingHeight, amountOfWindows, furniture, floor, washingMachine, stove, squareMeterCost)
        {
            this.firstRoomArea = firstRoomArea;
            this.secondRoomArea = secondRoomArea;
            this.thirdRoomArea = thirdRoomArea;
            this.fourthRoomArea = fourRoomArea;
            this.fifthRoomArea = fiveRoomArea;
        }

        double firstRoomArea;
        double secondRoomArea;
        double thirdRoomArea;
        double fourthRoomArea;
        double fifthRoomArea;

        public override double GetRent()
        {
            double rent = (firstRoomArea + secondRoomArea + thirdRoomArea + fourthRoomArea + fifthRoomArea) * squareMeterCost;
            return rent;
        }

        public override double GetSquare()
        {
            double square = firstRoomArea + secondRoomArea + thirdRoomArea + fourthRoomArea + fifthRoomArea;
            return square;
        }
    }
}
