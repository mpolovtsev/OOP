using FlatsLibrary;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Flat flat = new OneRoomFlat(3, 2.5, 6, true, 5, false, "Газовая", 3, 7);
            double expected = 21.0;
            double result = flat.GetRent();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test2()
        {
            Flat flat = new TwoRoomFlat(3, 2.5, 6, true, 5, false, "Газовая", 3, 7, 10);
            double expected = 51.0;
            double result = flat.GetRent();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test3()
        {
            Flat flat = new ThreeRoomFlat(3, 2.5, 6, true, 5, false, "Газовая", 3, 7, 10, 3);
            double expected = 60.0;
            double result = flat.GetRent();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test4()
        {
            Flat flat = new FourRoomFlat(3, 2.5, 6, true, 5, false, "Газовая", 3, 7, 10, 3, 4);
            double expected = 72.0;
            double result = flat.GetRent();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test5()
        {
            Flat flat = new FiveRoomFlat(3, 2.5, 6, true, 5, false, "Газовая", 3, 7, 10, 3, 4, 5);
            double expected = 87.0;
            double result = flat.GetRent();
            Assert.AreEqual(expected, result);
        }
    }
}